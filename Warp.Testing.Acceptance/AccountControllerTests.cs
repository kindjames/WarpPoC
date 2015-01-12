using NUnit.Framework;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using Warp.WebUI.Controllers;
using Warp.WebUI.Models.Authentication;

namespace Warp.Testing.Acceptance
{
    public class when_logging_in_with_valid_credentials : SpecsFor<MvcWebApp>
    {
        protected override void Given()
        {
            SUT.NavigateTo<AuthenticationController>(c => c.LogOff());
            SUT.NavigateTo<AuthenticationController>(c => c.Login(null));
        }

        protected override void When()
        {
            SUT.FindFormFor<LoginViewModel>()
                .Field(m => m.UserName).SetValueTo("test3@test.com")
                .Field(m => m.Password).SetValueTo("test3")
                .Submit();
        }

        [Test]
        public void it_should_login_to_home_page()
        {
            SUT.Route.ShouldMapTo<HomeController>(c => c.Index());
        }
    }
}