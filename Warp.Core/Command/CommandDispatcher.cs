using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;

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
    }
}