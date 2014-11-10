using System;
using System.Diagnostics;
using FluentValidation;
using Warp.Core.Exceptions;
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

        public void Execute(ICommand command)
        {
            Validate(command);

            var handlerType = typeof(ICommandHandler<>)
                .MakeGenericType(command.GetType());

            var handler = _serviceLocator.TryResolve(handlerType);

            if (handler == null)
            {
                throw new CommandHandlerNotFoundException(command);
            }

            ((dynamic)handler).Execute((dynamic)command);
        }

        private void Validate(ICommand command)
        {
            var validatorType = typeof(AbstractValidator<>)
                .MakeGenericType(command.GetType());

            var validator = _serviceLocator.TryResolve(validatorType);

            if (validator != null)
            {
                ((dynamic)validator).Validate((dynamic)command);
            }
            else if (Debugger.IsAttached)
            {
                throw new ValidatorNotFoundForEntityException(command.GetType());
            }
        }
    }
}