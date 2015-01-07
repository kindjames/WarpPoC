using System.ComponentModel.DataAnnotations;
using System.Linq;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;

namespace Warp.Data.Validation
{
    public class DataAnnotationsValidator : IValidator
    {
        private readonly IServiceLocator _serviceLocator;

        public DataAnnotationsValidator(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public void Validate(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(true);

                foreach (var attribute in attributes.OfType<CheckEntityExistsAttribute>())
                {
                    attribute.QueryDispatcher = _serviceLocator.TryResolve<IQueryDispatcher>();
                }
            }

            Validator.TryValidateObject(obj, new ValidationContext(obj), null, true);
        }
    }
}