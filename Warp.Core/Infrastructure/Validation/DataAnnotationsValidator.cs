using System.ComponentModel.DataAnnotations;

namespace Warp.Core.Infrastructure.Validation
{
    public class DataAnnotationsValidator : IValidator
    {
        public void Validate(object obj)
        {
            Validator.TryValidateObject(obj, new ValidationContext(obj), null, true);
        }
    }
}