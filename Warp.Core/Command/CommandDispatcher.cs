using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceLocator _serviceLocator;

        public CommandDispatcher(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        //public TResult Execute<TResult>(IQuery<TResult> query)
        //    where TResult : class
        //{
        //    var handlerType = typeof(IQueryHandler<,>)
        //        .MakeGenericType(query.GetType(), typeof(TResult));

        //    var handler = _dependencyResolver.TryResolve(handlerType);
            
        //    if (handler == null)
        //    {
        //        throw new QueryHandlerNotFoundException<TResult>(query);
        //    }

        //    try
        //    {
        //        return (TResult)((dynamic)handler).Execute((dynamic)query);
        //    }
        //    finally
        //    {
        //        _dependencyResolver.Release(handler);
        //    }
        //}

        public void Execute(ICommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}