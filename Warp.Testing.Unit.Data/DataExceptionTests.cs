using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Data;
using Warp.Data.Exceptions;
using ThenIt = Machine.Specifications.It;

namespace Warp.Testing.Unit.Data
{
    [Subject("Data Exceptions")]
    public class DataExceptionTests
    {
        public class TestDataEntity : EntityBase {}

        public class When_DataEntityNotFoundException_is_built : WithSubject<DataEntityNotFoundException<TestDataEntity>>
        {
            Establish that = () => Configure(x => x.For<int>().Use(99));

            ThenIt should_build_the_correct_error_message = () => 
                Subject.ShouldContainErrorMessage("Unable to find TestDataEntity for Id 99 in database.");
        }
    }
}