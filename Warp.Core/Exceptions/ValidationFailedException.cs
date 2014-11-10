using System;
using System.Collections.Generic;
using System.Linq;
using FluentValidation.Results;

namespace Warp.Core.Exceptions
{
    public sealed class ValidationFailedException : Exception
    {
        public ValidationFailedException(object instance, ICollection<ValidationFailure> errors)
            : base(BuildMessage(instance, errors))
        {
        }

        private static string BuildMessage(object instance, ICollection<ValidationFailure> errors)
        {
            var errorsDetail = errors.Count() == 1 
                ? errors.Single().ErrorMessage
                : String.Concat(errors.Select(x => "\r\n - " + x.ErrorMessage));
            
            return String.Concat("Validation failed when validating '", instance.GetType().Name, "' : ", errorsDetail);
        }
    }
}