using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Command;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Param = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Core.Specs
{
    [Subject("Command Dispatcher")]
    public class CommandDispatcherTests
    {
        public class When__Execute__is_called_and_no_CommandHandler_is_found_for_Command : WithSubject<CommandDispatcher>
        {
            private static Exception _exception;
            private static ICommand _mockCommand;

            Establish that = () =>
            {
                _mockCommand = An<ICommand>();

                The<IServiceLocator>()
                    .WhenToldTo(r => r.TryResolve(typeof(ICommandHandler<>)))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockCommand));

            ThenIt should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<CommandHandlerNotFoundException>();
            };
        }

        public class When__Execute__is_called : WithSubject<CommandDispatcher>
        {
            Establish that = () =>
            {
                _expectedResult = Guid.NewGuid().ToString();

                _serviceLocator = The<IServiceLocator>();

                _mockCommand = An<ICommand>();
                
                // Mock command Handler
                _mockCommandHandler = An<ICommandHandler<ICommand>>();

                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(typeof(ICommandHandler<>).MakeGenericType(_mockCommand.GetType())))
                    .Return(_mockCommandHandler);
            };

            Because of = () => Subject.Execute(_mockCommand);

            ThenIt should_call__Validate__on_handler = () =>
                The<IValidator>().WasToldTo(v => v.Validate(_mockCommand));

            ThenIt should_call__Execute__on_handler = () =>
                _mockCommandHandler.WasToldTo(h => h.Execute(_mockCommand));

            static ICommand _mockCommand;
            static ICommandHandler<ICommand> _mockCommandHandler;
            static IServiceLocator _serviceLocator;
            static string _expectedResult;
        }

        public class When__Execute__is_called_and_CommandHandler_throws_an_exception : WithSubject<CommandDispatcher>
        {
            Establish that = () =>
            {
                _mockCommand = An<ICommand>();
                _serviceLocator = The<IServiceLocator>();

                _mockCommand = An<ICommand>();

                // Mock command Handler
                _mockCommandHandler = An<ICommandHandler<ICommand>>();

                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(typeof(ICommandHandler<>).MakeGenericType(_mockCommand.GetType())))
                    .Return(_mockCommandHandler);

                // Set up mock handler to throw an Exception when Execute() is called.
                _mockCommandHandler
                    .WhenToldTo(h => h.Execute(_mockCommand))
                    .Throw(new Exception());
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockCommand));

            ThenIt should_call__Execute__on_handler = () =>
                _mockCommandHandler.WasToldTo(h => h.Execute(_mockCommand));

            static ICommand _mockCommand;
            static ICommandHandler<ICommand> _mockCommandHandler;
            static IServiceLocator _serviceLocator;
            static Exception _exception;
        }
    }
}
