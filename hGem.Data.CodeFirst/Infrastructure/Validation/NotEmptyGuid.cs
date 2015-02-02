using System;
using System.ComponentModel.DataAnnotations;

namespace hGem.Data.Infrastructure.Validation
{
    public sealed class NotEmptyGuidAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            if (value is string == false && value is Guid == false)
            {
                return ValidationResult.Success;
            }

            var guid = value as Guid? ?? Guid.Empty;

            var s = value as string;

            if (s != null && Guid.TryParse(s, out guid) == false)
            {
                return new ValidationResult("The value is not compatible with Guid type");
            }

            return guid == Guid.Empty ? new ValidationResult("Value cannot be empty") : ValidationResult.Success;
        }
    }
}
