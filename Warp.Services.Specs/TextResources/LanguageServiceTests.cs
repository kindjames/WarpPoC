using Machine.Fakes;
using Machine.Specifications;
using Warp.Core.Services.TextResourceService;

namespace Warp.Services.Specs.TextResources
{
    [Subject("Language Service -  Logon")]
    public static class LanguageServiceTests
    {
        public class When_No_User_Is_Logged_On_Return_LanguageId_For_Invariant_Culture : WithSubject<LanguageService>
        {
            Establish context = () =>
                The<ILanguageService>()
                .WhenToldTo(l => l.GetBrowserLanguageIdForInvariantCulture(InvariantCulture))
                .Return(BrowserLanguageId);
                
            Because of = () =>
                _result = Subject.GetBrowserLanguageIdForInvariantCulture(InvariantCulture);

            It should = () => _result.ShouldEqual(BrowserLanguageId);

            static int _result;
            private const string InvariantCulture = "en";
            private const int BrowserLanguageId = 1;
            // GetBrowserLanguageIdForInvariantCulture(string invariantCulture)
        }
    }
}
