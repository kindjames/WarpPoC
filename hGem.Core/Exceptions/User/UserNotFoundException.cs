using System;

namespace hGem.Core.Exceptions.User
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message)
            : base(BuildErrorMessage(message))
        { }

        static string BuildErrorMessage(string message)
        {
            return String.Concat("User not found for Id: ", message);
        }
    }
}
