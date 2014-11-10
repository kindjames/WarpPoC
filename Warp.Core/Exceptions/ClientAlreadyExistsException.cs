using System;

namespace Warp.Core.Exceptions
{
    public class ClientAlreadyExistsException : Exception
    {
        public ClientAlreadyExistsException(int customerId, string code)
            : base (BuildMessage(customerId, code))
        {
        }

        private static string BuildMessage(int customerId, string code)
        {
            return String.Concat("Client already exists for Customer Id: ", customerId, ", Code: ", code, ".");
        }
    }
}