using System;

namespace Warp.Core.Exceptions
{
    public class ClientAlreadyExistsException : Exception
    {
        public ClientAlreadyExistsException(Guid customerId, string code)
            : base (BuildMessage(customerId, code))
        {
        }

        private static string BuildMessage(Guid customerId, string code)
        {
            return String.Concat("Client already exists for CustomerId Id: ", customerId, ", Code: ", code, ".");
        }
    }
}