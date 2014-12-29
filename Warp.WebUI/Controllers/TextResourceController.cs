using System.Web.Mvc;
using AutoMapper;
using Warp.Core.Services.TextResourceService;
using Warp.WebUI.Models.TextResources;

namespace Warp.WebUI.Controllers
{
    public class TextResourceController : Controller
    {
        private readonly IMappingEngine _mappingEngine;
        private readonly ITextResourceService _textResourceService;

        public TextResourceController(IMappingEngine mappingEngine, ITextResourceService textResourceService)
        {
            _mappingEngine = mappingEngine;
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