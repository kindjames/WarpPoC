﻿using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using System.Web.Mvc;
using Warp.Core.Authentication;
using Warp.WebUI.Models.Authentication;

namespace Warp.WebUI.Controllers
{
    [RoutePrefix("authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationManager _authenticationManager;
        private readonly UserManager<ApplicationUser, int> _userManager;

        public AuthenticationController(UserManager<ApplicationUser, int> userManager, IAuthenticationManager authenticationManager)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("log-off")]
        public ActionResult LogOff()
        {
            _authenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }

        [AllowAnonymous]
        [Route("login")]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("login")]
        public async Task<ActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindAsync(model.UserName, model.Password);

                if (user != null)
                {
                    _authenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);

                    var identity = await _userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

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