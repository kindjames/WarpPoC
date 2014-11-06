using System;

namespace Warp.Core.Exceptions
{
    public class ClientNotFoundException : Exception
    {
        public ClientNotFoundException(int clientId)
            : base ("Client not found for id " + clientId)
        {
        }
    }
}