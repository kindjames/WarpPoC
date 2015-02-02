using System;
using hGem.Core.Services.TextResourceService;
using hGem.Services;
using Machine.Fakes;
using Machine.Specifications;

namespace hGem.Testing.Unit.Services.TextResources
{
    [Subject("Language Service -  Logon")]
    public static class LanguageServiceTests
    {
        [Ignore("JK -> PG - this doesn't test the LanguageService (the subject), as it's mocking an interface of the LanguageService, and isn't mocking the queries it uses under the covers.")]
        public class When_No_User_Is_Logged_On_Return_LanguageId_For_Invariant_Culture : WithSubject<LanguageService>
        {
            Establish context = () =>
                The<ILanguageService>()
                .WhenToldTo(l => l.GetBrowserLanguageIdForInvariantCulture(InvariantCulture))
                .Return(BrowserLanguageId);
                
            Because of = () =>
                _result = Subject.GetBrowserLanguageIdForInvariantCulture(InvariantCulture);

            It should = () => _result.ShouldEqual(BrowserLanguageId);

            static Guid _result;
            private const string InvariantCulture = "en";
            readonly static Guid BrowserLanguageId = Guid.NewGuid();
        }
    }
}
