using SpecsFor.Mvc;
using SpecsFor.Mvc.Authentication;
using Warp.WebUI.Controllers;
using Warp.WebUI.ViewModels.Authentication;

namespace Warp.Testing.Acceptance
{
    public class StandardAuthenticator : IHandleAuthentication
    {
        public void Authenticate(MvcWebApp mvcWebApp)
        {
            mvcWebApp.NavigateTo<AuthenticationController>(c => c.Login(null));

            mvcWebApp.FindFormFor<LoginViewModel>()
                .Field(m => m.UserName).SetValueTo("test3@test.com")
                .Field(m => m.Password).SetValueTo("test3")
                .Submit();
        }
    }
}