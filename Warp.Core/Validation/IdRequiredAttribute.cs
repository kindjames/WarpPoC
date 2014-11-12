using System;
using System.ComponentModel.DataAnnotations;

namespace Warp.Core.Validation
{
    public class IdRequiredAttribute : ValidationAttribute
    {
        private string _message;

        public override bool IsValid(object value)
        {
            var id = Convert.ToInt32(value);

            if (id < 1)
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