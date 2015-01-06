using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using Warp.Testing.Unit.Data.Commands.Clients;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Queries.TextResources
{
    [Subject("GetTextResourceString Query Handler")]
    public class GetTextResourceStringQueryHandlerUnitTests
    {
        public class GetTextResourceString_That_Exists : WithSubject<GetTextResourceStringQueryHandler>
        {
            static string _result = "Text Resource Test String!";
            static readonly Guid _textResourceId = Guid.NewGuid();

            Establish _that = () =>
            {
                The<ITextResourceDbContext>()
                    .WhenToldTo(tr => tr.TextResources)
                    .Return(new TestDbSet<TextResource>
                    {
                        new TextResource
                        {
                            Id = Guid.NewGuid(),
                            TextResourceIdentifier = new TextResourceIdentifier { Id = _textResourceId},
                            ResourceString = "Text Resource Test String.",
                            Language = new Language { Id = Guid.NewGuid() }
                        }
                    });

            };

            Because _of = () => _result = Subject.Handle(new GetTextResourceStringQuery { TextResourceIdentifierId = _textResourceId });

            It _should_not_be_null = () =>
            {
                _result.ShouldNotBeNull();
                _result.ShouldEqual("Text Resource Test String.");
            };
        }

        public class GetTextResourceString_That_Does_Not_Exists : WithSubject<GetTextResourceStringQueryHandler>
        {
            static string _result = "Text Resource Test String!";
            static readonly Guid _textResourceId = Guid.NewGuid();

            Establish _that = () =>
            {
                The<ITextResourceDbContext>()
                    .WhenToldTo(tr => tr.TextResources)
                    .Return(new TestDbSet<TextResource>
                    {
                        new TextResource
                        {
                            Id = Guid.NewGuid(),
                            TextResourceIdentifier = new TextResourceIdentifier { Id = _textResourceId}
                        }
                    });

            };

            Because _of = () => _result = Subject.Handle(new GetTextResourceStringQuery { TextResourceIdentifierId = _textResourceId });

            It _should_be_null = () => _result.ShouldBeNull();
        }

    }
}
