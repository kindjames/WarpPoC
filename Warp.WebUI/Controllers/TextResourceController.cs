using System.Web.Mvc;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Services.TextResourceService;
using Warp.WebUI.Models.TextResources;

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

        [HttpPost, Route("create")]
        public ActionResult Create(TextResourceViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!model.ForceAdd)
                {
                    if (_textResourceService.CheckResourceCodeExists(model.TextResourceCode))
                    {
                        ModelState.AddModelError("", "Text resource code already exists - please tick Force Add.");
                        // return associated TextResource data model
                    }
                    else if (_textResourceService.CheckResourceStringExists(model.TextResourceString))
                    {
                        ModelState.AddModelError("", "Text resource string already exists - please tick Force Add.");
                        // return  associated TextResourceIdentifier data model
                    }
                    else
                    {
                        // Sweet path
                    }
                }

                var dto = _mappingEngine.Map<TextResourceViewModel, SaveTextResourceDto>(model);

                _textResourceService.SaveResource(dto);

                return RedirectToAction("View", new { textResourceId = dto.LanguageId });
            }
            return View(model);
        }

        //[HttpGet, Route("{TextResourceId:int}")]
        //public ActionResult View(int textResourceId)
        //{
        //    var textResource = _textResourceService.GetTextResource(textResourceId);

        //    var viewModel = _mappingEngine.Map<TextResourceDto, TextResourceViewModel>(textResource);

        //    return View(viewModel);
        //}
    }
}