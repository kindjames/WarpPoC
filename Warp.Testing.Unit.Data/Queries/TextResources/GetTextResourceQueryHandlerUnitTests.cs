using System;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using Warp.Testing.Unit.Data.Commands.Clients;
using Warp.Testing.Unit.Data.Data;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Queries.TextResources
{
    [Subject("TextResource => Service => Query Tests")]
    public class GetTextResourceQueryHandlerUnitTests
    {
        public static TextResourceTestDataFactory _textResourceTestData;
        public static TextResourceIdentifierTestDataFactory _textResourceCodeTestData;

        public GetTextResourceQueryHandlerUnitTests()
        {
            _textResourceTestData = new TextResourceTestDataFactory();
            _textResourceCodeTestData = new TextResourceIdentifierTestDataFactory();
        }

        public class GetTextResource_That_Exists: WithSubject<GetTextResourceQueryHandler>
        {
            static string _result;
            static readonly Guid _textResourceCodeId = Guid.NewGuid();
 
            Establish _that = () =>
            {
               // Add some dummy TextResources to the in-memory DbContext.
                The<ITextResourceDbContext>()
                    .WhenToldTo(d => d.TextResources)
                    .Return(new TestDbSet<TextResource>
                    {
                        new TextResource
                        {
                            Id = Guid.NewGuid(),
                            Language = new Language { Id = Guid.NewGuid() },
                            TextResourceIdentifier = new TextResourceIdentifier { Id = _textResourceCodeId},
                            ResourceString = "Welcome!"
                        }
                    });
            };

            Because _of = () => _result = Subject.Handle(new GetTextResourceQuery { TextResourceIdentifierId = _textResourceCodeId });

            It should_return_the_TextResource = () =>
            {
                _result.ShouldNotBeNull();
            };
        }

        //public class When_querying_a_TextResource_for_its_TextResourceCode :
        //    WithSubject<GetTextResourceCodeQueryHandler>
        //{
            
        //    Establish _that = () =>
        //    {
        //        The<ITextResourceDbContext>()
        //            .WhenToldTo(d => d.TextResources)
        //            .Return(_textResourceTestData.BuildMemorySet().ToInMemoryDbSet());
        //    };

        //    Because _of = () => _result = Subject.Execute(new GetTextResourceCodeQuery { TextResourceCodeId = 1 });

        //    It should_return_the_correct_language_id = () =>
        //        _result.ShouldEqual("WelcomeText");

        //    static string _result;
        //    static GetTextResourceCodeQuery _query;
        //}
    }
}