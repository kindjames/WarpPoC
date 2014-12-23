﻿using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;

namespace Warp.Data.Specs.Queries.TextResources
{
    [Subject("GetTextResourceString Query Handler")]
    public class GetTextResourceStringQueryHandlerTests
    {
        public class GetTextResourceString_That_Exists : WithSubject<GetTextResourceStringQueryHandler>
        {
            static string _result = "Text Resource Test String!";
            const int _textResourceId = 10;

            Establish _that = () =>
            {
                The<ITextResourceDbContext>()
                    .WhenToldTo(tr => tr.TextResources)
                    .Return(new InMemoryDbSet<TextResource>(true)
                    {
                        new TextResource
                        {
                            Id = 1,
                            TextResourceIdentifier = new TextResourceIdentifier { Id = _textResourceId},
                            ResourceString = "Text Resource Test String.",
                            Language = new Language { Id = 1 }
                        }
                    });

            };

            Because _of = () => _result = Subject.Execute(new GetTextResourceStringQuery { TextResourceIdentifierId = 10 });

            It _should = () =>
            {
                _result.ShouldNotBeNull();
                _result.ShouldEqual("Text Resource Test String.");
            };
        }

        public class GetTextResourceString_That_Does_Not_Exists : WithSubject<GetTextResourceStringQueryHandler>
        {
            static string _result = "Text Resource Test String!";
            static int _textResourceId = 0;

            Establish _that = () =>
            {
                The<ITextResourceDbContext>()
                    .WhenToldTo(tr => tr.TextResources)
                    .Return(new InMemoryDbSet<TextResource>(true)
                    {
                        new TextResource
                        {
                            Id = 999,
                            TextResourceIdentifier = new TextResourceIdentifier { Id = _textResourceId}
                        }
                    });

            };

            Because _of = () => _result = Subject.Execute(new GetTextResourceStringQuery { TextResourceIdentifierId = _textResourceId });

            It _should = () => _result.ShouldBeNull();
        }

    }
}
