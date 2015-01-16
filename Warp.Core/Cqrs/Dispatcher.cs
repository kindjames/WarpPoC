using System;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Services.Dtos.Client;

namespace Warp.Core.Cqrs
{
    public class Dispatcher : IDispatcher
    {
        private readonly IObjectMapper _objectMapper;
        private readonly IServiceLocator _serviceLocator;

        public Dispatcher(IObjectMapper objectMapper, IServiceLocator serviceLocator)
        {
            _objectMapper = objectMapper;
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

            ((dynamic)handler).Handle(command);
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

        public void ExecuteUsingDto<TCommand>(DtoBase dto)
            where TCommand : ICommand, new()
        {
            var command = _objectMapper.MapTo<TCommand>(dto);

            GetCommandHandler<TCommand>()
                .Handle(command);
        }

        public TResult ExecuteUsingDto<TQuery, TResult>(DtoBase dto)
            where TQuery : IQuery<TResult>, new()
        {
            var query = _objectMapper.MapTo<TQuery>(dto);

            return GetQueryHandler<TQuery, TResult>()
                .Handle(query);
        }
    }
}