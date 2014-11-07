using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceLocator _serviceLocator;

        public QueryDispatcher(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            var handler = _serviceLocator.TryResolve(handlerType);
            
            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(query);
            }

            return (TResult)((dynamic)handler).Execute((dynamic)query);
        }
    }
}