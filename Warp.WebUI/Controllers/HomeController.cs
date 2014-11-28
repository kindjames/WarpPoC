using System.Security.Claims;
using System.Security.Principal;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
using Warp.WebUI.Infrastructure;
using Warp.WebUI.Models.Brands;

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

        //public ActionResult Index(int id)
        //{
        //    var dto = _brandService.GetBrandSummaryListForClient(id);

        //    var viewModel = _objectMapper.Map<BrandSummaryListDto, BrandSummaryListViewModel>(dto);

        //    return View(viewModel);
        //}
	}
}

namespace Warp.Services.Providers
{
}