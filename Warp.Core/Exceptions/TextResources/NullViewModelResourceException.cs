using System;

namespace Warp.Core.Exceptions.TextResources
{
    public class NullViewModelResourceException : Exception
    {
        public NullViewModelResourceException(string message)
            : base("View Model Resource is Null for Id : " + message) { }
    }
}
