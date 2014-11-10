using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions;
using Warp.Core.Util;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Core.Specs
{
    [Subject("Check tests")]
    public class CheckTests
    {
        public class When_calling__NotNull__with_a_null_parameter : WithSubject<Check>
        {
            Because of = () => exception = Catch.Exception(() => Check.NotNull<object>(null, "testParam"));

            It should_throw_an_exception = () =>
            {
                exception.ShouldNotBeNull();
                exception.ShouldBeOfExactType<ArgumentNullException>();
                exception.ShouldContainErrorMessage("testParam");
            };

            static Exception exception;
        }
        public class When_calling__NotNull__with_a_non_null_parameter : WithSubject<Check>
        {
            Because of = () => result = Check.NotNull("BLAH", "testParam");

            It should_return_parameter = () => result.ShouldEqual("BLAH");

            static string result;
        }
    }
}