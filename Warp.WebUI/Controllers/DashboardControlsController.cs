using System.Web.Mvc;

namespace Warp.WebUI.Controllers
{
    public class DashboardControlsController : Controller
    {
        [ChildActionOnly]
        public ActionResult TopNavigationBar()
        {
            var model = new TopNavigationBarViewModel
            {
                ApplicationTitle = "HospitalityGEM"
            };
            
            return PartialView(model);
        }

        [ChildActionOnly]
        public ActionResult SideNavigationBar()
        {
            var model = new SideNavigationBarViewModel();

            return PartialView(model);
        }
    }

    public class SideNavigationBarViewModel
    {
    }

    public class TopNavigationBarViewModel
    {
        public string ApplicationTitle { get; set; }
    }
}