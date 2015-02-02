using System.Security.Claims;
using System.Web.Mvc;
using hGem.WebUI.Infrastructure;

namespace Warp.WebUI.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            return View();
        }

        [RequiredRoles("DeleteVisit")]
        public virtual ActionResult AdminTest()
        {
            var a = User.Identity;

            var identity = User.Identity as ClaimsIdentity;

            return View();
        }
    }
}