using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Core.Query
{
    public class QueryDispatcher : IQueryDispatcher
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly IValidator _validator;

        public QueryDispatcher(IServiceLocator serviceLocator, IValidator validator)
        {
            _serviceLocator = serviceLocator;
            _validator = validator;
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            _validator.Validate(query);

            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(query.GetType(), typeof(TResult));

            var handler = _serviceLocator.TryResolve(handlerType);
            
            if (handler == null)
            {
                throw new QueryHandlerNotFoundException<TResult>(query);
            }

            return ((dynamic)handler).Execute((dynamic) query);
        }
    }
}