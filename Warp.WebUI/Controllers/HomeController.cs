using System.Security.Claims;
using System.Web.Mvc;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.WebUI.Infrastructure;

namespace Warp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IObjectMapper _objectMapper;

        public HomeController(IBrandService brandService, IObjectMapper objectMapper)
        {
            _brandService = brandService;
            _objectMapper = objectMapper;
        }

        public ActionResult Index()
        {
            var a = User.Identity;

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