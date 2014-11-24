using System.ComponentModel.DataAnnotations;

namespace Warp.Core.Infrastructure.Validation
{
    public class DataAnnotationsValidator : IValidator
    {
        public void Validate(object obj)
        {
            Validator.ValidateObject(obj, new ValidationContext(obj), true);
        }
    }
}