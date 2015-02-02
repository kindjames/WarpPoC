using System;
using hGem.Core.Data;

namespace hGem.Core.Exceptions.Data
{
    public abstract class DataEntityNotFoundException : DataLayerException
    {
        protected DataEntityNotFoundException(string message)
            : base(message)
        {
        }
    }

    public class DataEntityNotFoundException<TEntity> : DataEntityNotFoundException
        where TEntity : EntityBase
    {
        public DataEntityNotFoundException(Guid entityId, string additionalErrorMessageInformation = null)
            : base(BuildErrorMessage(entityId, additionalErrorMessageInformation))
        {
        }

        private static string BuildErrorMessage(Guid entityId, string additionalErrorMessageInformation)
        {
            return String.Concat("Unable to find ", typeof(TEntity).Name, " for Id ", entityId, " in database. ",
                additionalErrorMessageInformation);
        }
    }
}