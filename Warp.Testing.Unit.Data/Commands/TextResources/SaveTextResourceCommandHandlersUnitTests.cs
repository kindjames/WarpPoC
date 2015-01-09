using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Query;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Data.Commands.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.TextResources
{
    [Subject("TextResource Service Unit Tests")]
    public static class SaveNewTextResourceCommandHandlerUnitTests
    {
        #region TextResource Tests

        // Sweet Path. No duplicates, !ClientOverridable.
        public class When_calling__SaveNewTextResource__Unique_ResourceCode_Unique_ResourceString_Not_Client_overridable
            : WithSubject<SaveTextResourceCommandHandler>
        {
            private static IDbSet<TextResourceIdentifier> _textResourceIdentifiers;
            private static IDbSet<TextResource> _textResources;
 
            private static SaveTextResourceCommand _rootCommand;

            private static bool _clientOverridable = false;
            private const string _resourceIdentifierCode = "WelcomeText";
            private const string _resourceString = "Welcome!";
            private const int _languageId = 1;

            private Establish _that = () =>
            {
                Configure(om => om.For<IObjectMapper>().Use<ObjectMapper>());
                Configure(Mapper.Engine);

                _rootCommand = new SaveTextResourceCommand(){ ClientOverridable = _clientOverridable, ResourceIdentifierCode = _resourceIdentifierCode, ResourceString = _resourceString, LanguageId = _languageId };

                The<IQueryDispatcher>()
                    .WhenToldTo(c => c.Execute(MoqIt.IsAny<ValidateUniqueResourceCodeQuery>()))
                    .Return(true);

                The<IQueryDispatcher>()
                    .WhenToldTo(c => c.Execute(MoqIt.IsAny<ValidateUniqueResourceStringQuery>()))
                    .Return(true);
            };

            private Because _of = () => Subject.Execute(new SaveTextResourceCommand());
            
            It _should_add_new_TextResource_to_the_TextResource_repository =
                () => _textResources.WasToldTo(t => t.Add(MoqIt.IsAny<TextResource>()));

            It _should_call_SaveChanges_on_UoW = () => The<ITextResourceDbContext>().WasToldTo(s => s.SaveChanges());
        }

        public class When_calling__SaveNewTextResource__Unique_ResourceCode_Unique_ResourceString_Client_overridable
            : WithSubject<SaveTextResourceCommandHandler>
        {
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

        #region TextResource Identifier


        #endregion

        #region Resource String Tests
        //private static IDbSet<TextResourceIdentifier> _tRIRepository;
        //private string _resourceCode = "Welcome";
        //private bool _clientOverridable = false;

        //static SaveTextResourceDto _dto;

        #endregion
    }
}
