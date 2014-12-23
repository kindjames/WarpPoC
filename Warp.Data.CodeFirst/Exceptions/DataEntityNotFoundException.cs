using System;
using Warp.Core.Data;

namespace Warp.Data.Exceptions
{
    public class DataEntityNotFoundException<TEntity> : Exception
        where TEntity : EntityBase
    {
        public DataEntityNotFoundException(int entityId)
            : base(String.Concat("Unable to find ", typeof(TEntity).Name, " for Id ", entityId, " in database."))
        {
        }
    }
}