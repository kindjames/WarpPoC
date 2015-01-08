using System;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Util;

namespace Warp.Core.Command
{
    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly IValidator _validator;

        public CommandDispatcher(IServiceLocator serviceLocator, IValidator validator)
        {
            _serviceLocator = serviceLocator;
            _validator = validator;
        }

        public void Execute(ICommand command)
        {
            CheckArgument.NotNull(command, "command");

            _validator.Validate(command);

            var handlerType = typeof(ICommandHandler<>)
                .MakeGenericType(command.GetType());

            var handler = _serviceLocator.TryResolve(handlerType);

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException(command);
            }

            ((dynamic)handler).Execute((dynamic)command);
        }

        public void Execute<TCommand>(Func<TCommand, TCommand> command)
            where TCommand : class, ICommand, new()
        {
            CheckArgument.NotNull(command, "command");

            var c = command(new TCommand());

            _validator.Validate(command);

            var handler = _serviceLocator.TryResolve<ICommandHandler<TCommand>>();

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException(c);
            }

            handler.Execute(c);
        }
    }
}