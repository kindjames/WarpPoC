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
            _serviceLocator.TryResolve<AbstractValidator<T>>()
                .ValidateAndThrow(obj);
        }
    }
}