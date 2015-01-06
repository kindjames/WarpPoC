using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Warp.Core.Authentication;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.WebUI.Models.Account;

namespace Warp.WebUI.Controllers
{
    [Authorize]
    [RoutePrefix("account")]
    public class AccountController : Controller
    {
        private readonly IAuthenticationManager _authenticationManager;
        private readonly IObjectMapper _objectMapper;
        private readonly UserManager<ApplicationUser, int> _userManager;

        public AccountController(UserManager<ApplicationUser, int> userManager, IAuthenticationManager authenticationManager, IObjectMapper objectMapper)
        {
            _userManager = userManager;
            _authenticationManager = authenticationManager;
            _objectMapper = objectMapper;
        }

        [AllowAnonymous]
        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [Route("register")]
        public async Task<ActionResult> Register(RegisterViewModel model)
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
        public ActionResult UserProfile()
        {
            var id = User.Identity.GetUserId<int>();

            var user = _userManager.FindById(id);

            var model = _objectMapper.Map<ApplicationUser, UserProfileModel>(user);

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> UserProfile(UserProfileModel model)
        {
            var id = User.Identity.GetUserId<int>();

            var user = _userManager.FindById(id);

            user.Email = model.Email;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;

            await _userManager.UpdateAsync(user);

            return View(model);
        }
    }
}