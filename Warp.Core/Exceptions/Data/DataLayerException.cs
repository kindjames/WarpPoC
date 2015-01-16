using System;

namespace Warp.Core.Exceptions.Data
{
    public abstract class DataLayerException : Exception
    {
        protected DataLayerException(string message)
            : base(message)
        {
        }
    }
}