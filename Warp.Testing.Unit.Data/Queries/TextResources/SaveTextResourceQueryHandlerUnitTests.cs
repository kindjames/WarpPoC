using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Queries.TextResources;

namespace Warp.Testing.Unit.Data.Queries.TextResources
{
    [Subject("SaveTextResource QueryHandler Unit Tests")]
    public class SaveTextResourceQueryHandlerTests
    {
        #region Test Base Class for CheckIsResourceStringUniqueQueryHandler
        public class ValidateClientResourceQueryHandlerBaseContext : WithSubject<CheckIsResourceStringUniqueQueryHandler>
        {
            Establish context = () =>
            {
                
            };
        }

        #endregion Test Base Class for CheckIsResourceStringUniqueQueryHandler

        #region Client Validation Resource Tests

        [Subject("Client Validation Resource Tests")]
        public class ClientValidationResourceTests : ValidateClientResourceQueryHandlerBaseContext
        {
            
        }
        
        #endregion Client Validation Resource Tests
    }


    [Subject("SaveTextResource CommandHandler Unit Tests ")]
    public class SaveTextResourceCommandHandlerUnitTestsBaseContext
    {
        Establish context = () =>
        {
            
        };
    }
}