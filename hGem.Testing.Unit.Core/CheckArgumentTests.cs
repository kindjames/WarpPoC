using System;
using System.Collections.Generic;
using hGem.Core.Infrastructure.Util;
using Machine.Fakes;
using Machine.Specifications;

namespace hGem.Testing.Unit.Core
{
    [Subject("CheckArgument tests")]
    public class CheckArgumentTests
    {
        public class When_calling__NotNull__with_a_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNull<object>(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentNullException>();
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNull__with_a_non_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotNull("BLAH", "testParam");

            It should_return_parameter = () => _result.ShouldEqual("BLAH");

            static string _result;
        }

        public class When_calling__NotNullAndHasItems__with_a_null_collection : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNullAndHasItems<IEnumerable<object>>(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentNullException>();
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNullAndHasItems__with_an_empty_collection : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotNullAndHasItems(new object[0], "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Collection has no items.");
                _exception.ShouldContainErrorMessage("testParam");
            };

            static Exception _exception;
        }

        public class When_calling__NotNullAndHasItems__with_a_collection_containing_items : WithSubject<CheckArgument>
        {
            Establish context = () => _collection = new[] {"TestItem1", "TestItem2"};

            Because of = () => _result = CheckArgument.NotNullAndHasItems(_collection, "testParam");

            It should_return_collection = () =>
            {
                _result.ShouldNotBeNull();
                _result.ShouldContain(_collection);
            };

            static IEnumerable<string> _result;
            static IEnumerable<string> _collection;
        }

        public class When_calling__NotEmpty__with_a_null_string : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_an_empty_string : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty(String.Empty, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_a_string_containing_only_whitespace : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotEmpty("    ", "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' is null, empty or contains only whitespace.");
            };

            static Exception _exception;
        }

        public class When_calling__NotEmpty__with_a_non_null_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotEmpty("BLAH", "testParam");

            It should_return_parameter = () => _result.ShouldEqual("BLAH");

            static string _result;
        }


        public class When_calling__NotZero__with_a_parameter_of_zero : WithSubject<CheckArgument>
        {
            Because of = () => _exception = Catch.Exception(() => CheckArgument.NotZero(0, "testParam"));

            It should_throw_an_exception = () =>
            {
                _exception.ShouldNotBeNull();
                _exception.ShouldBeOfExactType<ArgumentException>();
                _exception.ShouldContainErrorMessage("Parameter 'testParam' cannot be zero.");
            };

            static Exception _exception;
        }

        public class When_calling__NotZero__with_a_non_zero_parameter : WithSubject<CheckArgument>
        {
            Because of = () => _result = CheckArgument.NotZero(Int32.MaxValue, "testParam");

            It should_return_parameter = () => _result.ShouldEqual(Int32.MaxValue);

            static int _result;
        }
    }
}