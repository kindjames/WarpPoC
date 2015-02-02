using System;
using hGem.WebUI.ViewModels.Authentication;
using NUnit.Framework;
using Should;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using hGem.WebUI.Controllers;

namespace hGem.Testing.Integration
{
    public class AuthenticationControllerTests
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

                SUT.FindLinkTo<AuthenticationController>(c => c.LogOff())
                    .Click();
            }

            [Test]
            public void then_it_should_login_to_home_page()
            {
                SUT.Route.ShouldMapTo<HomeController>(c => c.Index());
            }
        }

        public class when_logging_in_with_invalid_credentials : SpecsFor<MvcWebApp>
        {
            protected override void Given()
            {
                SUT.NavigateTo<AuthenticationController>(c => c.LogOff());
                SUT.NavigateTo<AuthenticationController>(c => c.Login(null));
            }

            protected override void When()
            {
                SUT.FindFormFor<LoginViewModel>()
                    .Field(m => m.UserName).SetValueTo(Guid.NewGuid().ToString())
                    .Field(m => m.Password).SetValueTo(Guid.NewGuid().ToString())
                    .Submit();
            }

            [Test]
            public void then_it_should_display_an_error()
            {
                SUT.ValidationSummary.Text.ShouldContain("Invalid username or password.");
                SUT.Route.ShouldMapTo<AuthenticationController>(c => c.Login(null));
            }
        }
    }
}