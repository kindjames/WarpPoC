﻿using System;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.IoC;

namespace Warp.Core.Cqrs
{
    public class Dispatcher : IDispatcher
    {
        private readonly IServiceLocator _serviceLocator;

        public Dispatcher(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
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

        protected ICommandHandler<TCommand> GetCommandHandler<TCommand>()
            where TCommand : ICommand
        {
            var handler = GetCommandHandler(typeof(TCommand));

            return (ICommandHandler<TCommand>) handler;
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
            var handler = GetCommandHandler(command.GetType());

            ((dynamic) handler).Handle(command);
        }

        public TResult Execute<TResult>(IQuery<TResult> query)
        {
            var handler = GetQueryHandler<TResult>(query.GetType());

            return ((dynamic)handler).Handle(query);
        }

        public TResult Execute<TQuery, TResult>()
            where TQuery : IQuery<TResult>, new()
        {
            return GetQueryHandler<TQuery, TResult>()
                .Handle(new TQuery());
        }
    }
}