using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using Machine.Fakes;
using Machine.Specifications;
using Machine.Specifications.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Moq;
using Warp.Core.Authentication;
using Warp.WebUI.Controllers;
using Warp.WebUI.Models.Authentication;
using WarpPoC.Testing.Util;
using It = Machine.Specifications.It;
using Param = Moq.It;

namespace Warp.Testing.Unit.WebUI
{
    [Subject("Authentication Controller")]
    public class AuthenticationControllerTests
    {
        public class When_logging_off : WithSubject<AuthenticationController>
        {
            static ActionResult _result;

            Because of = () =>
                _result = Subject.LogOff();

            It should_allow_POST_calls = () =>
                Subject.ShouldAcceptHttpPostRequests(c => c.LogOff());

            It should_call__SignOut__on__IAuthenticationManager__ = () =>
                The<IAuthenticationManager>()
                    .WasToldTo(m => m.SignOut());

            It should_redirect_to_home = () =>
                _result.ShouldRedirectToAction((HomeController c) => c.Index());
        }

        public class When_logging_in_with_invalid_logon_details : WithSubject<AuthenticationController>
        {
            static AwaitResult<ActionResult> _result;

            Establish that = () =>
            {
                Subject.ModelState.AddModelError("", "");
            };

            Because of = () =>
                _result = Subject.Login(new LoginViewModel(), Param.IsAny<String>())
                .Await(); // As it's async.

            It should_only_accept_POST_requests = () =>
                Subject.ShouldAcceptHttpPostRequests(c => c.Login(Param.IsAny<LoginViewModel>(), Param.IsAny<String>()));

            It should_redirect_home = () =>
                _result.AsTask.Result.ShouldBeAView();
        }

        public class When_logging_in_with_wrong_user_details : WithSubject<AuthenticationController>
        {
            static AwaitResult<ActionResult> _result;

            Establish that = () =>
            {
                var userManager = new Mock<UserManager<ApplicationUser, int>>(An<IUserStore<ApplicationUser, int>>());

                userManager.Setup(m => m.FindAsync(Param.IsAny<String>(), Param.IsAny<String>()))
                    .Returns(Task.FromResult((ApplicationUser)null))
                    .Verifiable();

                Configure(userManager.Object);
            };

            Because of = () =>
                _result = Subject.Login(new LoginViewModel(), Param.IsAny<String>())
                .Await(); // As it's async.

            It should_only_accept_POST_requests = () =>
                Subject.ShouldAcceptHttpPostRequests(c => c.Login(Param.IsAny<LoginViewModel>(), Param.IsAny<String>()));

            It should_destroy_existing_session_and_create_new_one = () =>
                Subject.ModelState.Values.Single().Errors.ShouldContain(e => e.ErrorMessage == "Invalid username or password.");

            It should_redirect_home = () =>
                _result.AsTask.Result.ShouldBeAView();
        }

        public class When_logging_in_with_valid_user_details : WithSubject<AuthenticationController>
        {
            static AwaitResult<ActionResult> _result;
            static ApplicationUser _testUser;
            static ClaimsIdentity _testIdentity;
            static LoginViewModel _model;

            Establish that = () =>
            {
                _testUser = new ApplicationUser
                {
                    Email = "test@test.com",
                    FirstName = "Tessa",
                    LastName = "Testson",
                    CustomerId = 69
                };

                _testIdentity = new ClaimsIdentity();

                _model = new LoginViewModel();

                var userManager = new Mock<UserManager<ApplicationUser, int>>(An<IUserStore<ApplicationUser, int>>());

                userManager.Setup(m => m.FindAsync(Param.IsAny<String>(), Param.IsAny<String>()))
                    .ReturnsAsync(_testUser)
                    .Verifiable();

                userManager.Setup(m => m.CreateIdentityAsync(Param.IsAny<ApplicationUser>(), Param.IsAny<String>()))
                    .ReturnsAsync(_testIdentity)
                    .Verifiable();

                Configure(userManager.Object);

                Subject.Url = An<UrlHelper>();

                Subject.Url.WhenToldTo(u => u.IsLocalUrl(Param.IsAny<String>()))
                    .Return(false);
            };

            Because of = () =>
                _result = Subject.Login(_model, Param.IsAny<String>())
                .Await(); // As it's async.

            It should_only_accept_POST_requests = () =>
                Subject.ShouldAcceptHttpPostRequests(c => c.Login(Param.IsAny<LoginViewModel>(), Param.IsAny<String>()));

            It should_add_claims = () =>
            {
                _testIdentity.FindFirstValue(ClaimTypes.Email)
                    .ShouldEqual(_testUser.Email);

                _testIdentity.FindFirstValue(ClaimTypes.GivenName)
                    .ShouldEqual(_testUser.FirstName + " " + _testUser.LastName);

                _testIdentity.FindFirstValue(ApplicationClaimTypes.CustomerId)
                    .ShouldEqual(_testUser.CustomerId.ToString());
            };

            It should_destroy_existing_session_and_create_new_one = () =>
            {
                The<IAuthenticationManager>()
                    .WasToldTo(m => m.SignOut(DefaultAuthenticationTypes.ExternalCookie));

                The<IAuthenticationManager>()
                    .WasToldTo(m => m.SignIn(Param.IsAny<AuthenticationProperties>(), _testIdentity));
            };

            It should_redirect_home = () =>
                _result.AsTask.Result.ShouldRedirectToAction((HomeController c) => c.Index());
        }

        public class When_logging_in_with_valid_user_details_and_a_return_url_is_specified : WithSubject<AuthenticationController>
        {
            static AwaitResult<ActionResult> _result;
            static ApplicationUser _testUser;
            static ClaimsIdentity _testIdentity;
            static LoginViewModel _model;
            const string ReturnUrl = "TESTURL";

            Establish that = () =>
            {
                _testUser = new ApplicationUser
                {
                    Email = "test@test.com",
                    FirstName = "Tessa",
                    LastName = "Testson",
                    CustomerId = 69
                };

                _testIdentity = new ClaimsIdentity();

                _model = new LoginViewModel();

                var userManager = new Mock<UserManager<ApplicationUser, int>>(An<IUserStore<ApplicationUser, int>>());

                userManager.Setup(m => m.FindAsync(Param.IsAny<String>(), Param.IsAny<String>()))
                    .ReturnsAsync(_testUser)
                    .Verifiable();

                userManager.Setup(m => m.CreateIdentityAsync(Param.IsAny<ApplicationUser>(), Param.IsAny<String>()))
                    .ReturnsAsync(_testIdentity)
                    .Verifiable();

                Configure(userManager.Object);

                Subject.Url = An<UrlHelper>();

                Subject.Url.WhenToldTo(u => u.IsLocalUrl(Param.IsAny<String>()))
                    .Return(true);
            };

            Because of = () =>
                _result = Subject.Login(_model, ReturnUrl)
                .Await(); // As it's async.

            It should_only_accept_POST_requests = () =>
                Subject.ShouldAcceptHttpPostRequests(c => c.Login(Param.IsAny<LoginViewModel>(), Param.IsAny<String>()));

            It should_add_claims = () =>
            {
                _testIdentity.FindFirstValue(ClaimTypes.Email)
                    .ShouldEqual(_testUser.Email);

                _testIdentity.FindFirstValue(ClaimTypes.GivenName)
                    .ShouldEqual(_testUser.FirstName + " " + _testUser.LastName);

                _testIdentity.FindFirstValue(ApplicationClaimTypes.CustomerId)
                    .ShouldEqual(_testUser.CustomerId.ToString());
            };

            It should_destroy_existing_session_and_create_new_one = () =>
            {
                The<IAuthenticationManager>()
                    .WasToldTo(m => m.SignOut(DefaultAuthenticationTypes.ExternalCookie));

                The<IAuthenticationManager>()
                    .WasToldTo(m => m.SignIn(Param.IsAny<AuthenticationProperties>(), _testIdentity));
            };

            It should_redirect_to_URL = () =>
                _result.AsTask.Result
                    .ShouldBeA<RedirectResult>()
                    .And()
                    .Url.ShouldEqual(ReturnUrl);
        }
    }
}