using System;
using Warp.Core.Query;

namespace Warp.Core.Exceptions
{
    public class QueryHandlerNotFoundException<TResult> : Exception
    {
        public QueryHandlerNotFoundException(IQuery<TResult> query)
            : base("Unable to locate QueryHandler for " + query.GetType().Name + " with result of " + typeof(TResult) + ". Query detail -> " + query)
        {
        }
    }
}