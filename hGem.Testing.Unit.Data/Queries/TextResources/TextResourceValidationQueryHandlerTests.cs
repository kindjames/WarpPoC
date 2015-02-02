using Machine.Specifications;

namespace hGem.Testing.Unit.Data.Queries.TextResources
{
    [Subject("TextResource Validation Query Tests")]
    public class TextResourceValidationQueryHandlerTests
    {
        #region Validation Query Tests BaseClass

        public class Validate_TextResource_BaseContext
        {

            Establish context = () =>
            {
               
            

            };
        }

        #endregion Validation Query Tests BaseClass

        #region ValidateResourceStringQuery Tests

        [Subject("Validate_a_unique_resource_string")]
        public class Validate_a_unique_resource_string : Validate_TextResource_BaseContext
        {

        }

        #endregion ValidateResourceStringQuery Tests

        #region Validate ResourceIdentifierQuery Tests


        #endregion Validate ResourceIdentifierQuery Tests
    }
}
