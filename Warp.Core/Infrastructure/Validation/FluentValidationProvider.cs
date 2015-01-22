using System;
using FluentValidation;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Infrastructure.Validation
{
    public class FluentValidationProvider : IValidationProvider
    {
        private readonly IServiceLocator _serviceLocator;

        public FluentValidationProvider(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void ValidateAndThrow<T>(T obj) where T : class
        {
            var validator = _serviceLocator.TryResolve<AbstractValidator<T>>();

            if (validator == null)
            {
                Console.WriteLine("Warning: Validator not found for {0}.", typeof(T).Name);
            }
            else
            {
                validator.ValidateAndThrow(obj);
            }
        }
    }
}