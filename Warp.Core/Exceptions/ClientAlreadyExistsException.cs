using System;

namespace Warp.Core.Exceptions
{
    public class ClientAlreadyExistsException : Exception
    {
        public ClientAlreadyExistsException(int customerId, string code)
            : base (String.Concat("Client already exists for Customer Id: ", customerId, ", Code: ", code, "."))
        {
        }
    }
}