using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Fakes;
using Machine.Specifications;
using Machine.Specifications.Model;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Languages;
using Warp.Testing.Unit.Data.Data;
using Warp.Testing.Unit.Data.Util;

namespace Warp.Testing.Unit.Data.Queries.Languages
{
    [Subject("LanguageService Queries")]
    public class LanguageQueryTests
    {
        public class When_Querying_For_English_LanguageId : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            const string TestInvarCulture = "en";
            static Guid _result;
            static IEnumerable<Language> _testData;
            static Guid _englishLanguageId;

            Establish that = () =>
            {
                _testData = new LanguageTestDataFactory().Build().ToList();
                _englishLanguageId = _testData.Single(t => t.InvariantCulture == TestInvarCulture).Id;

                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(_testData.ToInMemoryDbSet());
            };

            Because of = () => _result = Subject.Handle(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = TestInvarCulture });

            It should_return_the_english_language_id = () => _result.ShouldEqual(_englishLanguageId);
        }

        public class When_Querying_For_French_LanguageId : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            const string TestInvarCulture = "fr";
            static Guid _result;
            static IEnumerable<Language> _testData;
            static Guid _frenchLanguageId;

            Establish that = () =>
            {
                _testData = new LanguageTestDataFactory().Build().ToList();
                _frenchLanguageId = _testData.Single(t => t.InvariantCulture == TestInvarCulture).Id;

                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(_testData.ToInMemoryDbSet());
            };

            Because of = () => _result = Subject.Handle(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = TestInvarCulture });

            It should_return_the_french_language_id = () => _result.ShouldEqual(_frenchLanguageId);
        }

        public class When_Querying_For_An_Unsupported_Language : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            const string TestInvarCulture = "xx";
            static Guid _result;

            Establish that = () =>
            {
                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(new LanguageTestDataFactory().Build().ToInMemoryDbSet());
            };

            Because of = () => _result = Subject.Handle(new GetLanguageIdByInvariantCultureQuery { InvariantCulture = TestInvarCulture });

            It should_return_empty_id = () => _result.ShouldEqual(Guid.Empty);
        }
    }
}
