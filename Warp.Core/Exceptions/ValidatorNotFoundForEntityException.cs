using System;

namespace Warp.Core.Exceptions
{
    public sealed class ValidatorNotFoundForEntityException : Exception
    {
        public ValidatorNotFoundForEntityException(Type entityType)
            : base (BuildMessage(entityType))
        {
        }

        private static string BuildMessage(Type entityType)
        {
            return String.Concat("Warning: Unable to find validator for ", entityType.Name,
                " -> create a class implementing AbstractValidator<", entityType.Name, ">.");
        }
    }
}