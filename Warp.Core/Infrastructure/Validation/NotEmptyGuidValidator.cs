using System;
using System.Linq.Expressions;
using FluentValidation.Validators;

namespace Warp.Core.Infrastructure.Validation
{
    public class NotEmptyGuidValidator : PropertyValidator
    {
        public NotEmptyGuidValidator(string errorMessageResourceName, Type errorMessageResourceType)
            : base(errorMessageResourceName, errorMessageResourceType)
        {
        }

        public NotEmptyGuidValidator(string errorMessage = "Must not be empty Guid.")
            : base(errorMessage)
        {
        }

        public NotEmptyGuidValidator(Expression<Func<string>> errorMessageResourceSelector)
            : base(errorMessageResourceSelector)
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            return context.PropertyValue != null && !IsEmptyGuid(context.PropertyValue);
        }

        private static bool IsEmptyGuid(object propertyValue)
        {
            if (propertyValue is Guid)
            {
                return (Guid) propertyValue == Guid.Empty;
            }

            return false;
        }
    }
}