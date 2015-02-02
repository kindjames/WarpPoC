using System;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using hGem.Core.Authentication;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.WebUI.Infrastructure;
using hGem.WebUI.ViewModels.Account;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace hGem.WebUI.Controllers
{
    [Authorize]
    [RoutePrefix("account")]
    public partial class AccountController : Controller
    {
        private readonly IAuthenticationManager _authenticationManager;
        private readonly IObjectMapper _objectMapper;
        private readonly UserManager<ApplicationUser, Guid> _userManager;

        public AccountController(UserManager<ApplicationUser, Guid> userManager, IAuthenticationManager authenticationManager, IObjectMapper objectMapper)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
            _objectMapper = objectMapper;
        }

        [AllowAnonymous]
        [Route("register")]
        public virtual ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("register")]
        public virtual async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = model.UserName };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);

                    var identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

                    _authenticationManager.SignIn(new AuthenticationProperties { IsPersistent = false }, identity);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error);
                }
            }

            return View(model);
        }

        [HttpGet]
        public virtual ActionResult UserProfile()
        {
            var user = _userManager.FindById(User.GetUserId());

            var model = _objectMapper.Map<ApplicationUser, UserProfileModel>(user);

            return View(model);
        }

        [HttpPost]
        public virtual async Task<ActionResult> UserProfile(UserProfileModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.FindById(User.GetUserId());

                user.Email = model.Email;
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;

                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    var rememberMe = User.Identity.GetClaimValueFor<bool>(ApplicationClaimTypes.RememberMe);

                    var identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

                    identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                    identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName + " " + user.LastName));
                    identity.AddClaim(new Claim(ApplicationClaimTypes.CustomerId, user.CustomerId.ToString()));
                    identity.AddClaim(new Claim(ApplicationClaimTypes.RememberMe, rememberMe.ToString()));

                    _authenticationManager.SignIn(new AuthenticationProperties { IsPersistent = rememberMe }, identity);

                    return RedirectToAction("Index", "Home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error);
                }
            }

            return View(model);
        }
    }
}