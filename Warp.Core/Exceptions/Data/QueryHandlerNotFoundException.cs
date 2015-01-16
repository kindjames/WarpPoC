using System;

namespace Warp.Core.Exceptions.Data
{
    public class QueryHandlerNotFoundException : DataLayerException
    {
        public QueryHandlerNotFoundException(Type queryType)
            : base(BuildMessage(queryType))
        {
        }

        private static string BuildMessage(Type queryType)
        {
            return String.Concat("Unable to locate QueryHandler for ", queryType.Name, ".");
        }
    }
}