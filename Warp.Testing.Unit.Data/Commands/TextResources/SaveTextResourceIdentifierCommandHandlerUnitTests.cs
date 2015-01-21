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
using Warp.Core.Cqrs;
using Warp.Data.Commands.TextResources;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using IObjectMapper = Warp.Core.Infrastructure.AutoMapper.IObjectMapper;
using MoqIt = Moq.It;

namespace Warp.Testing.Unit.Data.Commands.TextResources
{
    [Subject("SaveResourceIdentifier CommandHandler Unit Tests")]
    public class SaveTextResourceIdentifierCommandHandlerUnitTests
    {
        public class When_calling__SaveTextResourceIdentifier__Unique_ResourceCode_Unique_ResourceString_NotClientOverridable
            : WithSubject<SaveResourceIdentifierCodeCommandHandler>
        {
            // Test bjects
            private static IDbSet<TextResourceIdentifier> _textResourceIdentifiers;
            private static SaveResourceIdentifierCommand _command;

            // Test Values
            private static bool _clientOverridable = false;
            private const string _resourceIdentifierCode = "WelcomeText";

            private Establish _that = () =>
            {
                _textResourceIdentifiers = An<IDbSet<TextResourceIdentifier>>();

                Configure(om => om.For<IObjectMapper>().Use<ObjectMapper>());
                Configure(Mapper.Engine);

                The<IDispatcher>()
                    .WhenToldTo(c => c.Execute(MoqIt.IsAny<CheckIsResourceIdentifierCodeUniqueQuery>()))
                    .Return(true);



            };

            private Because _of = () => Subject.Handle(new SaveResourceIdentifierCommand());

            private It _should_add_new_TextResourceIdentifier_to_the_TextResourceIdentifier_repository =
                () => _textResourceIdentifiers.WasToldTo(t => t.Add(MoqIt.IsAny<TextResourceIdentifier>()));

            // It _should_return_a_new_TextResourceIdentifierId = () => _
            private It _should_call_SaveChanges_on_UoW = () => The<ITextResourceDbContext>().WasToldTo(s => s.SaveChanges()).Twice();
        }

    }
}
