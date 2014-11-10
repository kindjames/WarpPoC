using Machine.Fakes;
using Machine.Specifications;
using System;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Query;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Core.Specs
{
    [Subject("Brand Service")]
    public class QueryDispatcherTests
    {
        public class When_Execute_is_called_and_no_QueryHandler_is_found_for_Query : WithSubject<QueryDispatcher>
        {
            private static Exception _exception;
            private static IQuery<string> _mockQuery;

            Establish that = () =>
            {
                _mockQuery = An<IQuery<string>>();

                The<IServiceLocator>()
                    .WhenToldTo(r => r.TryResolve(MoqIt.IsAny<Type>()))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockQuery));

            ThenIt should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<QueryHandlerNotFoundException<string>>();
            };
        }

        public class When_Execute_is_called : WithSubject<QueryDispatcher>
        {
            static IQuery<string> _mockQuery;
            static IQueryHandler<IQuery<string>, string> _mockQueryHandler;
            static IServiceLocator _serviceLocator;
            static string _result;
            static string _expectedResult;

            Establish that = () =>
            {
                _expectedResult = Guid.NewGuid().ToString();

                _mockQuery = An<IQuery<string>>();

                _mockQueryHandler = An<IQueryHandler<IQuery<string>, string>>();

                _serviceLocator = The<IServiceLocator>();

                // Set up mock query handler to return from mock dependency resolver.
                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(MoqIt.IsAny<Type>()))
                    .Return(_mockQueryHandler);

                // Set up mock handler to return random string (Guid) when Execute() is called.
                _mockQueryHandler
                    .WhenToldTo(h => h.Execute(_mockQuery))
                    .Return(_expectedResult);
            };

            Because of = () => _result = Subject.Execute(_mockQuery);

            ThenIt should_call_Execute_on_handler = () =>
                _mockQueryHandler.WasToldTo(h => h.Execute(_mockQuery));

            ThenIt should_return_result = () =>
                _result.ShouldEqual(_expectedResult);
        }

        public class When_Execute_is_called_and_QueryHandler_throws_an_exception : WithSubject<QueryDispatcher>
        {
            static IQuery<string> _mockQuery;
            static IQueryHandler<IQuery<string>, string> _mockQueryHandler;
            static IServiceLocator _serviceLocator;
            static Exception _exception;

            Establish that = () =>
            {
                _mockQuery = An<IQuery<string>>();

                _mockQueryHandler = An<IQueryHandler<IQuery<string>, string>>();

                _serviceLocator = The<IServiceLocator>();

                // Set up mock query handler to return from mock dependency resolver.
                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(MoqIt.IsAny<Type>()))
                    .Return(_mockQueryHandler);

                // Set up mock handler to throw an Exception when Execute() is called.
                _mockQueryHandler
                    .WhenToldTo(h => h.Execute(_mockQuery))
                    .Throw(new Exception());
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockQuery));

            ThenIt should_call_Execute_on_handler = () =>
                _mockQueryHandler.WasToldTo(h => h.Execute(_mockQuery));
        }
    }
}
