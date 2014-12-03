using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;

namespace Warp.Data.Specs.Queries.TextResources
{
    [Subject("TextResource => Service => Query Tests")]
    public class GetTextResourceQueryHandlerTests
    {
        public class GetTextResource_That_Exists: WithSubject<GetTextResourceQueryHandler>
        {

            static TextResource _result;
            const int _textResourceCodeId = 12;
 
            Establish _that = () =>
            {
               // Add some dummy TextResources to the in-memory DbContext.
                The<ITextResourceDbContext>()
                    .WhenToldTo(d => d.TextResources)
                    .Return(new InMemoryDbSet<TextResource>(true)
                    {
                        new TextResource
                        {
                            TextResourceId = 1,
                            LanguageId = 1,
                            TextResourceCodeId = 12,
                            ResourceString = "Welcome!"
                        }
                    });
            };

            Because _of = () => _result = Subject.Execute(new GetTextResourceQuery{ TextResourceCodeId = _textResourceCodeId});

            It should_return_the_TextResource = () =>
            {
                _result.ShouldNotBeNull();
            };
        }

        public class When_querying_a_TextResource_for_its_ResourceCodeId : WithSubject<GetTextResourceCodeQueryHandler>
        {
            Establish _that = () =>
            {
                _query = new GetTextResourceCodeQuery { TextResourceCodeId = 1 };

                The<ITextResourceDbContext>()
                    .WhenToldTo(d => d.TextResources)
                    .Return(new InMemoryDbSet<TextResource>(true)
                    {
                        
                    });
            };

            Because _of = () => _result = Subject.Execute(_query);

            It should_return_the_correct_language_id = () =>
                _result.ShouldEqual(1);

            static int _result;
            static GetTextResourceCodeQuery _query;
        }
    }
}