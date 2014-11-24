using System.Web.Mvc;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Brand;
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

        public ActionResult Index(int id)
        {
            var dto = _brandService.GetBrandSummaryListForClient(id);

            var viewModel = _objectMapper.Map<BrandSummaryListDto, BrandSummaryListViewModel>(dto);

            return View(viewModel);
        }
	}
}