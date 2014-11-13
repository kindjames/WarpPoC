using System;
using Machine.Fakes;
using Machine.Specifications;
using Machine.Specifications.Mvc;
using System.Web.Mvc;
using Warp.Core.Infrastructure;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Controllers;
using Warp.WebUI.Models.Clients;
using Param = Moq.It;

namespace Warp.WebUI.Specs
{
    [Subject("Home Controller")]
    public class HomeControllerTests
    {
        public class When_creating_client_and_model_is_invalid : WithSubject<ClientsController>
        {
            static ActionResult _result;

            Establish that = () =>
                Subject.ModelState.AddModelError("", "");

            Because of = () =>
                _result = Subject.Create(Param.IsAny<ClientViewModel>());

            It should_return_a_not_attempt_to_save_client = () =>
            {
                The<IClientService>()
                    .WasNotToldTo(s => s.SaveClient(Param.IsAny<SaveClientDto>()));

                _result.ShouldBeAView();
            };
        }

        public class When_creating_client : WithSubject<ClientsController>
        {
            static ActionResult _result;

            Establish that = () =>
            {
                _model = new ClientViewModel();
                _dto = new SaveClientDto {Id = new Random().Next()};

                The<IObjectMapper>()
                    .WhenToldTo(m => m.Map<ClientViewModel, SaveClientDto>(_model))
                    .Return(_dto);
            };

            Because of = () =>
                _result = Subject.Create(_model);

            It should_save_client_and_redirect_to__View__action = () =>
            {
                The<IClientService>()
                    .WasToldTo(s => s.SaveClient(_dto));

                _result.ShouldRedirectToAction<ClientsController>(c => c.View(_dto.Id));
            };

            static ClientViewModel _model;
            static SaveClientDto _dto;
        }
    }
}