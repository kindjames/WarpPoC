using System.Linq;
using FluentValidation;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Services;

namespace Warp.Core.Infrastructure.Validation
{
    public class FluentValidator : IValidator
    {
        private readonly IServiceLocator _serviceLocator;

        public FluentValidator(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        private AbstractValidator<T> GetValidator<T>() where T : class
        {
            return _serviceLocator.TryResolve<AbstractValidator<T>>();
        }

        public IResponse Validate<T>(T obj) where T : class
        {
            var results = GetValidator<T>()
                .Validate(obj);

            return results.IsValid ? 
                new ValidationResponse() :
                new ValidationResponse(results.Errors.Select(e => e.ErrorMessage));
        }

        public IResponse<TResult> Validate<T, TResult>(T obj) where T : class
        {
            var results = GetValidator<T>()
                .Validate(obj);

            return results.IsValid ?
                new ValidationResponse<TResult>() :
                new ValidationResponse<TResult>(results.Errors.Select(e => e.ErrorMessage));
        }

        public bool IsValid<T>(T obj) where T : class
        {
            return GetValidator<T>()
                .Validate(obj)
                .IsValid;
        }

        public void TryValidateAndThrow<T>(T obj) where T : class
        {
            GetValidator<T>()
                .ValidateAndThrow(obj);
        }
    }
}