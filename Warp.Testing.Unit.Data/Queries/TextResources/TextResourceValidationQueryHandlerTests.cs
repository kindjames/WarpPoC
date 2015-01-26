using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;
using Machine.Fakes;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Testing.Unit.Data.Commands.TextResources;
using Warp.Testing.Unit.Data.Queries.Languages;


namespace Warp.Testing.Unit.Data.Queries.TextResources
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
