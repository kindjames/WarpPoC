using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;

namespace Warp.Core.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IDependencyResolver _dependencyResolver;

        public QueryDispatcher(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            var handler = _dependencyResolver.TryResolve(handlerType);
            
            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(query);
            }

            try
            {
                return (TResult)((dynamic)handler).Execute((dynamic)query);
            }
            finally
            {
                _dependencyResolver.Release(handler);
            }
        }
    }
}