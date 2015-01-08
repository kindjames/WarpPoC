using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Commands.TextResources;
using Warp.Data.Entities;

namespace Warp.Testing.Unit.Data.Commands.TextResources
{
    [Subject("TextResource Service Unit Tests")]
    public static class SaveNewTextResourceUnitTests
    {
        #region TextResourceIdentifier Tests

        public class When_calling__SaveNewTextResource__for_an_existing_ResourceCode_and_ResourceString_Not_client_overridable
            : WithSubject<SaveNewResourceIdentifierCommandHandler>
        {
            Establish _that = () => _dto = new SaveTextResourceDto();

            private static IDbSet<TextResourceIdentifier> _tRIRepository;
            private string _resourceCode = "Welcome";
            private bool _clientOverridable = false;

            static SaveTextResourceDto _dto;
        }

        //public class When_calling__SaveNewTextResource__for_a_unique_ResourceCode_and_ResourceString_client_overridable : WithSubject<SaveNewResourceIdentifierCommandHandler>
        //{
        //    private static IDbSet<TextResourceIdentifier> _textResourceIdentifierRepository;
        //}

        //public class When_calling__SaveNewTextResource__for_an_existing_unique_ResourceCode : WithSubject<SaveNewResourceIdentifierCommandHandler>
        //{
        //    private static IDbSet<TextResourceIdentifier> _textResourceIdentifierRepository;
        //}



        #endregion

        //#region Resource Tests

        //#endregion
        
        
        //#region  TextResource Tests

        //#endregion

    }
}
