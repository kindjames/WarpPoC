using System;
using Warp.Core.Data;

namespace Warp.Data.Exceptions
{
    public class DataEntityNotFoundException<TEntity> : Exception
        where TEntity : EntityBase
    {
        public DataEntityNotFoundException(int entityId)
            : this(entityId, String.Empty)
        {
        }

        public DataEntityNotFoundException(int entityId, string additionalErrorMessageInformation)
            : base(String.Concat("Unable to find ", typeof(TEntity).Name, " for Id ", entityId, " in database. ", additionalErrorMessageInformation))
        {
        }
    }
}