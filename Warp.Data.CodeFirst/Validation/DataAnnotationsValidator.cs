using System.ComponentModel.DataAnnotations;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Data.Validation
{
    public class DataAnnotationsValidator : IValidator
    {
        public void Validate(object obj)
        {
            Validator.TryValidateObject(obj, new ValidationContext(obj), null, true);
        }
    }
}