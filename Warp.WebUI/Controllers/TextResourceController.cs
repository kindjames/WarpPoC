using System.Web.Mvc;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.WebUI.Models.TextResources;
using TextResourceViewModel = Warp.WebUI.Models.TextResources.TextResourceViewModel;

namespace Warp.WebUI.Controllers
{
    public class TextResourceController : Controller
    {
        private readonly IObjectMapper _objectMapper;
        private readonly ITextResourceService _textResourceService;

        public TextResourceController(IObjectMapper objectMapper, ITextResourceService textResourceService)
        {
            _objectMapper = objectMapper;
            _textResourceService = textResourceService;
        }

        public ActionResult Index(TextResourcePageViewModel model)
        {
            return View(model);
        }

        //[HttpPost, Route("create")]
        //public ActionResult Create(TextResourceViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var dto = _objectMapper.Map<TextResourceViewModel, SaveTextResourceDto>(model);

        //        _textResourceService.SaveResource(dto);

        //        return RedirectToAction("View", new { textResourceId = dto.LanguageId });
        //    }
        //    return View(model);
        //}

        //[HttpGet, Route("{TextResourceId:int}")]
        //public ActionResult View(int textResourceId)
        //{
        //    var textResource = _textResourceService.GetTextResource(textResourceId);

        //    var viewModel = _objectMapper.Map<TextResourceDto, TextResourceViewModel>(textResource);

        //    return View(viewModel);
        //}
    }
}