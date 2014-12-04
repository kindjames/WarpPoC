using System;
using System.Web.Mvc;
using Machine.Fakes;
using Machine.Specifications;
using Machine.Specifications.Mvc;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.TextResources;
using Warp.Core.Services.TextResourceService;
using Warp.WebUI.Controllers;
using Warp.WebUI.Models.TextResources;
using Param = Moq.It;

namespace Warp.WebUI.Specs
{
    [Subject("TextResource Controller Tests")]
    public class TextResourceControllerTests
    {
        //public class When_Creating_TextResource_And_Model_Is_Invalid : WithSubject<TextResourceController>
        //{
        //    static ActionResult _result;

        //    Establish _that = () =>
        //        Subject.ModelState.AddModelError("", "");

        //    Because _of = () =>
        //        _result = Subject.Create(Param.IsAny<TextResourceViewModel>());

        //    It Should_Return_Failed_Save_Attempt = () =>
        //    {
        //        The<ITextResourceService>()
        //            .WasNotToldTo(s => s.SaveResource(Param.IsAny<SaveTextResourceDto>()));

        //        _result.ShouldBeAView();

        //    };

        //}

        //public class When_Creating_TextResource : WithSubject<TextResourceController>
        //{
        //    Establish _that = () =>
        //    {
        //        _model = new TextResourceViewModel();
        //        _dto = new SaveTextResourceDto {TextResourceId = new Random().Next()};

        //        The<IObjectMapper>()
        //            .WhenToldTo(m => m.Map<TextResourceViewModel, SaveTextResourceDto>(_model))
        //            .Return(_dto);
        //    };
                
        //    Because _of = () =>
        //        _result = Subject.Create(_model);

        //    It Should_Return_Failed_Save_Attempt = () =>
        //    {
        //        The<ITextResourceService>()
        //            .WasToldTo(s => s.SaveResource(_dto));

        //        _result.ShouldRedirectToAction<TextResourceController>(c => c.View(_dto.TextResourceId));

        //    };

        //    static TextResourceViewModel _model;
        //    static SaveTextResourceDto _dto;
        //    static ActionResult _result;
        //}
    }
}
