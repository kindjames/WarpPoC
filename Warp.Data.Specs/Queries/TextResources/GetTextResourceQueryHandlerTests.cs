﻿using FakeDbSet;
using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.TextResources;
using Warp.Data.Specs.Data;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Queries.TextResources
{
    [Subject("TextResource => Service => Query Tests")]
    public class GetTextResourceQueryHandlerTests
    {
        public static TextResourceTestDataFactory _textResourceTestData;
        public static TextResourceIdentifierTestDataFactory _textResourceCodeTestData;

        public GetTextResourceQueryHandlerTests()
        {
            _textResourceTestData = new TextResourceTestDataFactory();
            _textResourceCodeTestData = new TextResourceIdentifierTestDataFactory();
        }

        public class GetTextResource_That_Exists: WithSubject<GetTextResourceQueryHandler>
        {
            static string _result;
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
                            Language = new Language { LanguageId = 1 },
                            TextResourceIdentifier = new TextResourceIdentifier { TextResourceIdentifierId = 12},
                            ResourceString = "Welcome!"
                        }
                    });
            };

            Because _of = () => _result = Subject.Execute(new GetTextResourceQuery{ TextResourceIdentifierId = _textResourceCodeId});

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