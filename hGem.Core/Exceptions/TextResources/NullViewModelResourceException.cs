using System;

namespace hGem.Core.Exceptions.TextResources
{
    public class NullViewModelResourceException : Exception
    {
        public NullViewModelResourceException(string message)
            : base("View Model Resource is Null for Id : " + message) { }
    }
}
