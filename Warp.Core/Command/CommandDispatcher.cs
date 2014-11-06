using Warp.Core.Infrastructure;

namespace Warp.Core.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IDependencyResolver _dependencyResolver;

        public CommandDispatcher(IDependencyResolver dependencyResolver)
        {
            _dependencyResolver = dependencyResolver;
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