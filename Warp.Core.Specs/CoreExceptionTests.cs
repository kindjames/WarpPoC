using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Exceptions;
using MoqIt = Moq.It;
using ThenIt = Machine.Specifications.It;

namespace Warp.Core.Specs
{
    [Subject("Core Exceptions")]
    public class CoreExceptionTests
    {
        public class TestOne {}
        public class TestTwo {}

        public class When_ObjectMappingConfigurationNotFound_is_built : WithSubject<ObjectMappingConfigurationNotFound<TestOne, TestTwo>>
        {
            ThenIt should_build_the_correct_error_message = () => 
                Subject.ShouldContainErrorMessage(
                "Unable to locate object mapping configuration - IMappingConfiguration`2<TestOne, TestTwo>. " +
                "Ensure one has been created and registered with DI Container.");
        }

        public class When_ClientAlreadyExistsException_is_built : WithSubject<ClientAlreadyExistsException>
        {
            Establish that = () =>
            {
                Configure(x => x.For<string>().Use("BLAHTEST"));
                Configure(x => x.For<int>().Use(123));
            };
                
            ThenIt should_build_the_correct_error_message = () => 
                Subject.ShouldContainErrorMessage("Client already exists for Customer Id: 123, Code: BLAHTEST.");
        }
    }
}