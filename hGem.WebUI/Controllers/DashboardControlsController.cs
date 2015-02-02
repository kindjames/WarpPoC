using System;
using System.Security.Claims;
using System.Web.Mvc;
using hGem.Core.Authentication;
using hGem.WebUI.ViewModels.DashboardControls;

namespace hGem.WebUI.Controllers
{
    [Authorize]
    [ChildActionOnly]
    public partial class DashboardControlsController : Controller
    {
        public virtual ActionResult TopNavigationBar()
        {
            var model = new TopNavigationBarViewModel
            {
                ApplicationTitle = "HospitalityGEM"
            };
            
            return PartialView(model);
        }

        public virtual ActionResult SideNavigationBar()
        {
            var model = new SideNavigationBarViewModel();

            return PartialView(model);
        }

        public virtual ActionResult TasksDropdown()
        {
            return PartialView();
        }

        public virtual ActionResult NotificationsDropdown()
        {
            return PartialView();
        }

        public virtual ActionResult MessagesDropdown()
        {
            return PartialView();
        }

        public virtual ActionResult UserDropdown()
        {
            return PartialView(new UserDropdownModel
            {
                ShortName = User.Identity.GetOrThrowClaimValueFor<string>(ClaimTypes.GivenName),
                LastLoggedIn = DateTime.Now,
            });
        }
    }
}