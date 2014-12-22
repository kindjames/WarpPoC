using System;

namespace Warp.Core.Exceptions.User
{
    public class ClaimNotFoundOnIdentityException : Exception
    {
        public ClaimNotFoundOnIdentityException(string claimType)
            : base("Cannot find claim on identity -> " + claimType)
        {
        }
    }
}