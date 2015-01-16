using System;
using System.ComponentModel.DataAnnotations;

namespace Warp.Core.Infrastructure.Validation
{
    public class IdRequiredAttribute : ValidationAttribute
    {
        private string _message;

        public override bool IsValid(object value)
        {
            Guid id;

            var isGuid = Guid.TryParse(value.ToString(), out id);

            if (!isGuid || id == Guid.Empty)
            {
                _message = "{0} must be set.";
                return false;
            }

            return true;
        }

        public override string FormatErrorMessage(string name)
        {
            return String.Format(_message, name);
        }
    }
}