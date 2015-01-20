using System.ComponentModel.DataAnnotations;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Validation
{
    public class DataAnnotationsValidator : IValidator
    {
        public ValidationResponse Validate(object obj)
        {
            var validationContext = new ValidationContext(obj);

            if (!Validator.TryValidateObject(obj, validationContext, null, true))
            {
                foreach (var c in validationContext.Items)
                {
                    c.
                }
                return new ValidationResponse();
            }

            return new ValidationResponse();
        }
    }
}