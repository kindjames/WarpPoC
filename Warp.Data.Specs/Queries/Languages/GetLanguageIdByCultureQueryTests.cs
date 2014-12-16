using Machine.Fakes;
using Machine.Specifications;
using Warp.Data.Context;
using Warp.Data.Queries.Languages;
using Warp.Data.Specs.Data;
using Warp.Data.Specs.Util;

namespace Warp.Data.Specs.Queries.Languages
{
    [Subject("LanguageService Queries")]
    public class LanguageQueryTests
    {
        static LanguageTestDataFactory _testData;

        public LanguageQueryTests()
        {
            _testData = new LanguageTestDataFactory();
        }

        public class When_Querying_For_English_LanguageId : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            static GetLanguageIdByInvariantCultureQuery _query;
            const string _testInvarCulture = "en";
            static int _result;
            const int _expectedResult = 1;

            Establish that = () =>
            {
                _query = new GetLanguageIdByInvariantCultureQuery() { InvariantCulture = _testInvarCulture };

                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(_testData.Build().ToInMemoryDbSet());
            };

            private Because of = () => _result = Subject.Execute(_query);

            private It should = () => _result.ShouldEqual(_expectedResult);
        }

        public class When_Querying_For_French_LanguageId : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            static GetLanguageIdByInvariantCultureQuery _query;
            const string _testInvarCulture = "fr";
            static int _result;
            const int _expectedResult = 2;

            Establish that = () =>
            {
                _query = new GetLanguageIdByInvariantCultureQuery() { InvariantCulture = _testInvarCulture };

                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(_testData.Build().ToInMemoryDbSet());
            };

            private Because of = () => _result = Subject.Execute(_query);

            private It should = () => _result.ShouldEqual(_expectedResult);
        }

        public class When_Querying_For_An_Unsupported_Language : WithSubject<GetLanguageIdByInvariantCultureQueryHandler>
        {
            static GetLanguageIdByInvariantCultureQuery _query;
            const string _testInvarCulture = "ru";
            static int _result;
            const int _expectedResult = 0;

            Establish that = () =>
            {
                _query = new GetLanguageIdByInvariantCultureQuery() { InvariantCulture = _testInvarCulture };

                The<ITextResourceDbContext>()
                    .WhenToldTo(a => a.Languages)
                    .Return(_testData.Build().ToInMemoryDbSet());
            };

            private Because of = () => _result = Subject.Execute(_query);

            private It should = () => _result.ShouldEqual(_expectedResult);

        }
    }
}
