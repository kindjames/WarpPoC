using System.Web.Mvc;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Services.TextResourceService;
using Warp.WebUI.ViewModels.TextResources;

namespace Warp.WebUI.Controllers
{
    public partial class TextResourceController : Controller
    {
        private readonly IObjectMapper _objectMapper;
        private readonly ITextResourceService _textResourceService;

        public TextResourceController(IObjectMapper objectMapper, ITextResourceService textResourceService)
        {
            _objectMapper = objectMapper;
            _textResourceService = textResourceService;
        }

        public virtual ActionResult Index(TextResourcePageViewModel model)
        {
            return View(model);
        }

        //[HttpPost, Route("create")]
        //public ActionResult Create(TextResourceViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dto = _mappingEngine.Map<TextResourceViewModel, SaveTextResourceDto>(model);

        //        _textResourceService.SaveResource(dto);

        //        return RedirectToAction("View", new { textResourceId = dto.LanguageId });
        //    }
        //    return View(model);
        //}

        //[HttpGet, Route("{TextResourceId:int}")]
        //public ActionResult View(int textResourceId)
        //{
        //    var textResource = _textResourceService.GetTextResource(textResourceId);

        //    var viewModel = _mappingEngine.Map<TextResourceDto, TextResourceViewModel>(textResource);

        //    return View(viewModel);
        //}
    }
}