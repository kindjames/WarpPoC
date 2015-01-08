using System;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Core.Query
{
    /// <summary>
    /// Given a Query, will validate it, find the appropriate QueryHandler, execute it, and return the result.
    /// </summary>
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly IValidator _validator;

        public QueryDispatcher(IServiceLocator serviceLocator, IValidator validator)
        {
            _serviceLocator = serviceLocator;
            _validator = validator;
        }

        public TResult Execute<TResult, TQuery>(Func<TQuery, TQuery> query)
            where TQuery : class, IQuery<TResult>, new()
        {
            var q = query(new TQuery());

            _validator.Validate(query);

            var handler = _serviceLocator.TryResolve<IQueryHandler<TQuery, TResult>>();

            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(q);
            }

            return handler.Execute(q);
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            _validator.Validate(query);

            // Attempt to find the QueryHandler
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            var handler = _serviceLocator.TryResolve(handlerType);

            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(query);
            }

            return ((dynamic)handler).Execute((dynamic)query);
        }
    }
}