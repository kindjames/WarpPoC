using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using ThenIt = Machine.Specifications.It;

namespace Warp.Testing.Unit.Core
{
    [Subject("Query Dispatcher")]
    public class QueryDispatcherTests
    {
        public class When__Execute__is_called_and_no_QueryHandler_is_found_for_Query : WithSubject<QueryDispatcher>
        {
            private static Exception _exception;
            private static IQuery<string> _mockQuery;

            Establish that = () =>
            {
                _mockQuery = An<IQuery<string>>();

                The<IServiceLocator>()
                    .WhenToldTo(r => r.TryResolve(typeof(IQueryHandler<,>)))
                    .Return(null);
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockQuery));

            ThenIt should_error = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<QueryHandlerNotFoundException<string>>();
            };
        }

        //public class When_Execute_is_called_and_no_QueryValidator_is_found_for_Query : WithSubject<QueryDispatcher>
        //{
        //    Establish that = () =>
        //    {
        //        _mockQuery = An<IQuery<string>>();

        //        _mockValidator = An<IQueryValidator<IQuery<string>, string>>();

        //        The<IServiceLocator>()
        //            .WhenToldTo(r => r.TryResolve(typeof(IQueryValidator<,>)))
        //            .Return(_mockValidator);
        //    };

        //    Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockQuery));

        //    ThenIt should_not_error = () => _exception.ShouldBeNull();

        //    static Exception _exception;
        //    static IQuery<string> _mockQuery;
        //    static IQueryValidator<IQuery<string>, string> _mockValidator;
        //}

        public class When__Execute__is_called : WithSubject<QueryDispatcher>
        {
            Establish that = () =>
            {
                _expectedResult = Guid.NewGuid().ToString();

                _serviceLocator = The<IServiceLocator>();

                _mockQuery = An<IQuery<string>>();
                
                // Mock query Handler
                _mockQueryHandler = An<IQueryHandler<IQuery<string>, string>>();

                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(typeof(IQueryHandler<,>).MakeGenericType(_mockQuery.GetType(), typeof(string))))
                    .Return(_mockQueryHandler);

                _mockQueryHandler
                    .WhenToldTo(h => h.Execute(_mockQuery))
                    .Return(_expectedResult);
            };

            Because of = () => _result = Subject.Execute(_mockQuery);

            ThenIt should_call__Validate__on_handler = () =>
                The<IValidator>().WasToldTo(v => v.Validate(_mockQuery));

            ThenIt should_call__Execute__on_handler = () =>
                _mockQueryHandler.WasToldTo(h => h.Execute(_mockQuery));

            ThenIt should_return_result = () =>
                _result.ShouldEqual(_expectedResult);

            static IQuery<string> _mockQuery;
            static IQueryHandler<IQuery<string>, string> _mockQueryHandler;
            static IServiceLocator _serviceLocator;
            static string _result;
            static string _expectedResult;
        }

        public class When__Execute__is_called_and_QueryHandler_throws_an_exception : WithSubject<QueryDispatcher>
        {
            Establish that = () =>
            {
                _mockQuery = An<IQuery<string>>();
                _serviceLocator = The<IServiceLocator>();

                _mockQuery = An<IQuery<string>>();

                // Mock query Handler
                _mockQueryHandler = An<IQueryHandler<IQuery<string>, string>>();

                _serviceLocator
                    .WhenToldTo(r => r.TryResolve(typeof(IQueryHandler<,>).MakeGenericType(_mockQuery.GetType(), typeof(string))))
                    .Return(_mockQueryHandler);

                // Set up mock handler to throw an Exception when Execute() is called.
                _mockQueryHandler
                    .WhenToldTo(h => h.Execute(_mockQuery))
                    .Throw(new Exception());
            };

            Because of = () => _exception = Catch.Exception(() => Subject.Execute(_mockQuery));

            ThenIt should_call_Execute_on_handler = () =>
                _mockQueryHandler.WasToldTo(h => h.Execute(_mockQuery));

            static IQuery<string> _mockQuery;
            static IQueryHandler<IQuery<string>, string> _mockQueryHandler;
            static IServiceLocator _serviceLocator;
            static Exception _exception;
        }
    }
}
