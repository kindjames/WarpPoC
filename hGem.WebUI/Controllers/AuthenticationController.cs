using System;
using System.Globalization;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Mvc;
using hGem.Core.Authentication;
using hGem.WebUI.Infrastructure;
using hGem.WebUI.ViewModels.Authentication;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace hGem.WebUI.Controllers
{
    [Authorize]
    [PopulateTextResourcesOnModel]
    [RoutePrefix("authentication")]
    public partial class AuthenticationController : Controller
    {
        private readonly IAuthenticationManager _authenticationManager;
        private readonly UserManager<ApplicationUser, Guid> _userManager;

        public AuthenticationController(UserManager<ApplicationUser, Guid> userManager, IAuthenticationManager authenticationManager)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("log-off")]
        public virtual ActionResult LogOff()
        {
            _authenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [Route("login")]
        public virtual ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View(new LoginViewModel());
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("login")]
        public virtual async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindAsync(model.UserName, model.Password);

                if (user != null)
                {
                    _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);

                    var identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);
                    
                    identity.AddClaim(new Claim(ClaimTypes.Email, user.Email));
                    identity.AddClaim(new Claim(ClaimTypes.GivenName, user.FirstName + " " + user.LastName));
                    identity.AddClaim(new Claim(ApplicationClaimTypes.CustomerId, user.CustomerId.ToString()));
                    identity.AddClaim(new Claim(ApplicationClaimTypes.RememberMe, model.RememberMe.ToString()));

                    _authenticationManager.SignIn(new AuthenticationProperties { IsPersistent = model.RememberMe }, identity);
                    
                    if (Url.IsLocalUrl(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }

                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Invalid username or password.");
            }

            return View(model);
        }
    }
}