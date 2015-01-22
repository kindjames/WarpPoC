using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Cqrs;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;

namespace Warp.Testing.Unit.Core
{
    [Subject("Dispatcher tests")]
    public class DispatcherTests
    {
        public class When_calling_Execute_for_Command_where_CommandHandler_does_not_exist : WithSubject<Dispatcher>
        {
            Establish context = () =>
            {
                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(An<ICommand>()));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<CommandHandlerNotFoundException>();
            };

            static Exception _exception;
        }

        public class When_calling_Execute_for_Command_where_CommandHandler_exists : WithSubject<Dispatcher>
        {
            Establish context = () =>
            {
                _command = An<ICommand>();
                _handler = An<ICommandHandler<ICommand>>();

                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(_handler);
            };

            Because of = () => Subject.Execute(_command);

            It should_validate_the_command = () => 
                The<IValidationProvider>().WasToldTo(v => v.ValidateAndThrow(_command));

            It should_call_Handle_on_the_CommandHandler_with_the_Command = () =>
                _handler.WasToldTo(h => h.Handle(_command));

            static ICommandHandler<ICommand> _handler;
            static ICommand _command;
        }

        public class When_calling_Execute_for_Query_where_QueryHandler_does_not_exist : WithSubject<Dispatcher>
        {
            Establish context = () =>
            {
                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(An<IQuery<string>>()));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<QueryHandlerNotFoundException>();
            };

            static Exception _exception;
        }

        public class When_calling_Execute_for_Query_where_QueryHandler_exists : WithSubject<Dispatcher>
        {
            Establish context = () =>
            {
                _query = An<IQuery<object>>();
                _handler = An<IQueryHandler<IQuery<object>, object>>();

                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(_handler);
            };

            Because of = () => Subject.Execute(_query);

            It should_validate_the_query = () =>
                The<IValidationProvider>().WasToldTo(v => v.ValidateAndThrow(_query));

            It should_call_Handle_on_the_QueryHandler_with_the_Query = () =>
                _handler.WasToldTo(h => h.Handle(_query));

            static IQueryHandler<IQuery<object>, object> _handler;
            static IQuery<object> _query;
        }

        public class When_calling_Execute_for_Query_that_does_not_have_parameters_where_QueryHandler_exists : WithSubject<Dispatcher>
        {
            public class AFakeWithNoParametersQuery : IQuery<object> { }

            Establish context = () =>
            {
                _handler = An<IQueryHandler<AFakeWithNoParametersQuery, object>>();

                The<IServiceLocator>()
                    .WhenToldTo(s => s.TryResolve(Param.IsAny<Type>()))
                    .Return(_handler);
            };

            Because of = () => Subject.Execute<AFakeWithNoParametersQuery, object>();

            It should_call_Handle_on_the_QueryHandler_with_the_Query = () =>
                _handler.WasToldTo(h => h.Handle(Param.IsAny<AFakeWithNoParametersQuery>()));

            static IQueryHandler<AFakeWithNoParametersQuery, object> _handler;
        }
    }
}