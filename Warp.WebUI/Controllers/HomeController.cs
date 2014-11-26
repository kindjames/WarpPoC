using System;
using System.Linq;
using System.Security.Principal;
using System.Web.Mvc;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
using Warp.WebUI.Models.Brands;

namespace Warp.WebUI.Controllers
{
    public sealed class RequiredRolesAttribute : AuthorizeAttribute
    {
        public RequiredRolesAttribute(params string[] roleNames)
        {
            Roles = String.Join(", ", roleNames);
        }
    }

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

        [RequiredRoles("GodMode")]
        public ActionResult AdminTest()
        {
            var a = User.Identity;

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