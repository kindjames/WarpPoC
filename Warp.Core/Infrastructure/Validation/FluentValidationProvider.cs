using System.Linq;
using FluentValidation;
using Warp.Core.Infrastructure.General;
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

        public IResponse Validate<T>(T obj) where T : class
        {
            var result = _serviceLocator.TryResolve<AbstractValidator<T>>()
                .Validate(obj);

            return result.IsValid
                ? new GeneralResponse()
                : new GeneralResponse(result.Errors.Select(e => e.ErrorMessage));
        }
    }
}