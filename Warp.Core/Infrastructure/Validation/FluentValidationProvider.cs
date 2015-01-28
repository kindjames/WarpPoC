using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure.Validation
{
    public class FluentValidationProvider : IValidationProvider
    {
        private readonly IServiceLocator _serviceLocator;
        static readonly Dictionary<Type, IEnumerable<Type>> ValidatorCache = new Dictionary<Type, IEnumerable<Type>>();

        public FluentValidationProvider(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public static IEnumerable<Type> GetInheritanceHierarchy(Type type)
        {
            for (var current = type; current != null; current = current.BaseType)
            {
                yield return current;
            }
        }

        public void ValidateAndThrow<T>(T obj) where T : class
        {
            var validationErrors = GetValidatorsFor<T>()
                .Select(v => v.Validate(obj))
                .Where(r => !r.IsValid)
                .SelectMany(r => r.Errors)
                .ToList();

            if (validationErrors.Any())
            {
                throw new ValidationException(validationErrors);
            }
        }

        private IEnumerable<IValidator> GetValidatorsFor<T>() where T : class
        {
            var objType = typeof(T);

            List<Type> typesWithValidator = null;
            IEnumerable<Type> baseTypes;

            // Have base types that have validators been found before?
            if (ValidatorCache.ContainsKey(objType))
            {
                baseTypes = ValidatorCache[objType];
            }
            else
            {
                baseTypes = GetInheritanceHierarchy(objType);
                typesWithValidator = new List<Type>();
            }

            var openValidatorType = typeof (AbstractValidator<>);

            // For each base type, create the Validator from the Service Locator.
            foreach (var baseType in baseTypes)
            {
                var validatorType = openValidatorType.MakeGenericType(baseType);

                var validator = _serviceLocator.TryResolve(validatorType) as IValidator;

                if (validator != null)
                {
                    yield return validator;

                    // Not null if cache-miss for this type.
                    if (typesWithValidator != null)
                    {
                        // Adds the type of T, for any validator that was found for T.
                        typesWithValidator.Add(baseType);
                    }
                }
            }

            // We've found all the validators for T and it's base classes.
            if (typesWithValidator != null)
            {
                // Add them to the cache for next time.
                ValidatorCache.Add(objType, typesWithValidator);
            }
        }
    }
}