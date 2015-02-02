using System.Data.Entity;
using AutoMapper;
using hGem.Core.Cqrs;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Data.Commands.TextResources;
using hGem.Data.Context;
using hGem.Data.Entities;
using hGem.Data.Queries.TextResources;
using Machine.Fakes;
using Machine.Specifications;
using IObjectMapper = hGem.Core.Infrastructure.AutoMapper.IObjectMapper;
using MoqIt = Moq.It;

namespace hGem.Testing.Unit.Data.Commands.TextResources
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
