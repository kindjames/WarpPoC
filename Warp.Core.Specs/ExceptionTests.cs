using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Core.Specs
{
    [Subject("Excedptions")]
    public class ExceptionTests
    {
        public class TestOne {}
        public class TestTwo {}

        public class When_Exception_is_built : WithSubject<ObjectMappingConfigurationNotFound<TestOne, TestTwo>>
        {
            ThenIt should_build_the_correct_error_message = () => 
                Subject.ShouldContainErrorMessage(
                "Unable to locate object mapping configuration, i.e. IMappingConfiguration`2<TestOne, TestTwo>." +
                " Ensure one has been created and registered with DI Container.");
        }
    }
}