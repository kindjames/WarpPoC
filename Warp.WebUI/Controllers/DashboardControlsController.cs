using System;
using System.Security.Claims;
using System.Web.Mvc;
using Warp.Core.Authentication;

namespace Warp.WebUI.Controllers
{
    [Authorize]
    [ChildActionOnly]
    public class DashboardControlsController : Controller
    {
        public ActionResult TopNavigationBar()
        {
            var model = new TopNavigationBarViewModel
            {
                ApplicationTitle = "HospitalityGEM"
            };
            
            return PartialView(model);
        }

        public ActionResult SideNavigationBar()
        {
            var model = new SideNavigationBarViewModel();

            return PartialView(model);
        }

        public ActionResult TasksDropdown()
        {
            return PartialView();
        }

        public ActionResult NotificationsDropdown()
        {
            return PartialView();
        }

        public ActionResult MessagesDropdown()
        {
            return PartialView();
        }

        public ActionResult UserDropdown()
        {
            return PartialView(new UserDropdownModel
            {
                ShortName = User.Identity.GetOrThrowClaimValueFor<string>(ClaimTypes.GivenName),
                LastLoggedIn = DateTime.Now,
            });
        }
    }

    public class UserDropdownModel
    {
        public string ShortName { get; set; }
        public DateTime LastLoggedIn { get; set; }
    }

    public class SideNavigationBarViewModel
    {
    }

    public class TopNavigationBarViewModel
    {
        public string ApplicationTitle { get; set; }
    }
}