using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Queries.TextResources;

namespace Warp.Testing.Unit.Data.Queries.TextResources
{
    [Subject("SaveTextResource Query Handler Unit Tests")]
    public class SaveTextResourceQueryHandlerTests
    {
        #region Test Base Class
        public class ValidateClientResourceQueryHandlerBaseContext : WithSubject<CheckIsResourceStringAssignedQueryHandler>
        {
            Establish context = () =>
            {
                
            };

        }

        #endregion Test Base Class

        #region Client Validation Resource Tests

        [Subject("Client Validation Resource Tests")]
        public class ClientValidationResourceTests : ValidateClientResourceQueryHandlerBaseContext
        {
            
        }
        
        #endregion Client Validation Resource Tests
    }
}