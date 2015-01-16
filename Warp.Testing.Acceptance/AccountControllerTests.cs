using System;
using System.Linq;
using NUnit.Framework;
using Should;
using SpecsFor;
using SpecsFor.Mvc;
using SpecsFor.Mvc.Helpers;
using Warp.Data.Migrations;
using Warp.WebUI.Controllers;
using Warp.WebUI.ViewModels.Account;
using Warp.WebUI.ViewModels.DashboardControls;

namespace Warp.Testing.Acceptance
{
    public class AccountControllerTests
    {
        public class when_logging_in_with_valid_credentials : SpecsFor<MvcWebApp>
        {
            private string FirstName = Guid.NewGuid().ToString();
            private string LastName = Guid.NewGuid().ToString();

            protected override void Given()
            {
                SUT.NavigateTo<AccountController>(c => c.UserProfile());
            }

            protected override void When()
            {
                SUT.FindFormFor<UserProfileModel>()
                    .Field(m => m.FirstName).SetValueTo(FirstName)
                    .Field(m => m.LastName).SetValueTo(LastName)
                    .Submit();
            }

            //[Test]
            //public void then_it_save_to_the_database()
            //{
            //    using (var context = new InternalMigrationsInitializationContext())
            //    {
            //        var user = context.Users
            //            .SingleOrDefault(u => u.Forename == FirstName && u.Surname == LastName);

            //        user.ShouldNotBeNull();
            //    }
            //}

            [Test]
            public void then_it_should_redirect_to_home()
            {
                SUT.Route.ShouldMapTo<HomeController>(c => c.Index());
            }

            [Test]
            public void then_it_should_have_updated_the_name_in_user_menu()
            {
                SUT.FindDisplayFor<UserDropdownModel>()
                    .DisplayFor(m => m.ShortName)
                    .Text.ShouldEqual(String.Concat(FirstName, " ", LastName));
            }
        }
    }
}