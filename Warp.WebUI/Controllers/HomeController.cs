using System.Security.Claims;
using System.Web.Mvc;
using Warp.WebUI.Infrastructure;

namespace Warp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [RequiredRoles("DeleteVisit")]
        public ActionResult AdminTest()
        {
            var a = User.Identity;

            var identity = User.Identity as ClaimsIdentity;

            return View();
        }
    }
}