using System;

namespace hGem.Core.Exceptions.Data
{
    public abstract class DataLayerException : Exception
    {
        protected DataLayerException(string message)
            : base(message)
        {
        }
    }
}