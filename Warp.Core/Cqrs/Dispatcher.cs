using System;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Core.Cqrs
{
    public class Dispatcher : IDispatcher
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly IValidationProvider _validationProvider;

        public Dispatcher(IServiceLocator serviceLocator, IValidationProvider validationProvider)
        {
            _serviceLocator = serviceLocator;
            _validationProvider = validationProvider;
        }

        protected object GetCommandHandler(Type commandType)
        {
            var handlerType = typeof(ICommandHandler<>)
                .MakeGenericType(commandType);

            var handler = _serviceLocator.TryResolve(handlerType);

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException(commandType);
            }

            return handler;
        }

        protected object GetQueryHandler<TResult>(Type queryType)
        {
            var handlerType = typeof(IQueryHandler<,>)
                .MakeGenericType(queryType, typeof(TResult));

            var handler = _serviceLocator.TryResolve(handlerType);

            if (handler == null)
            {
                throw new QueryHandlerNotFoundException(queryType);
            }

            return handler;
        }

        protected IQueryHandler<TQuery, TResult> GetQueryHandler<TQuery, TResult>()
            where TQuery : IQuery<TResult>
        {
            var handler = GetQueryHandler<TResult>(typeof(TQuery));

            return (IQueryHandler<TQuery, TResult>) handler;
        }

        public void Execute(ICommand command)
        {
            _validationProvider.ValidateAndThrow(command);

            var handler = GetCommandHandler(command.GetType());

            ((dynamic) handler).Handle((dynamic) command);
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            _validationProvider.ValidateAndThrow(query);

            var handler = GetQueryHandler<TResult>(query.GetType());

            return ((dynamic) handler).Handle((dynamic) query);
        }

        public TResult Execute<TQuery, TResult>()
            where TQuery : IQuery<TResult>, new()
        {
            return GetQueryHandler<TQuery, TResult>()
                .Handle(new TQuery());
        }
    }
}