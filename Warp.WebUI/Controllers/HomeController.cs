using System.Linq;
using System.Web.Mvc;
using Warp.Core.Services;
using Warp.WebUI.ViewModels;

namespace Warp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrandService _brandService;

        public HomeController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public ActionResult Index(int id)
        {
            var data = _brandService.GetBrandSummaryListForClient(id);

            var viewModel = new BrandSummaryListViewModel
            {
                ClientName = data.ClientName,
                CustomerName = data.CustomerName,
                BrandNames = data.Brands.Select(b => b.BrandName),
            };

            return View(viewModel);
        }
	}
}