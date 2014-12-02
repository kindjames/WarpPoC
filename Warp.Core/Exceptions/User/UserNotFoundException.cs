using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warp.Core.Exceptions.User
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
