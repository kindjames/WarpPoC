using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Web.Mvc;
using AutoMapper;
using Machine.Fakes;
using Machine.Specifications;
using Machine.Specifications.Mvc;
using Warp.Core.Authentication;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Controllers;
using Warp.WebUI.Models.Clients;
using Param = Moq.It;

namespace Warp.WebUI.Specs
{
    [Subject("Client Controller")]
    public class ClientsControllerTests
    {
        public class When_creating_client_and_model_is_invalid : WithSubject<ClientsController>
        {
            static ActionResult _result;

            Establish that = () =>
                Subject.ModelState.AddModelError("", "");

            Because of = () =>
                _result = Subject.Create(Param.IsAny<CreateClientModel>());

            It should_not_attempt_to_save_client = () =>
            {
                The<IClientService>()
                    .WasNotToldTo(s => s.SaveClient(Param.IsAny<SaveClientDto>()));

                _result.ShouldBeAView();
            };
        }

        public class When_creating_client_and_model_is_valid : WithSubject<ClientsController>
        {
            static ActionResult _result;
            static readonly int NewClientId = new Random().Next();

            Establish that = () =>
            {
                The<IMappingEngine>()
                    .WhenToldTo(m => m.Map<CreateClientModel, SaveClientDto>(Param.IsAny<CreateClientModel>()))
                    .Return(new SaveClientDto { Id = NewClientId });

                var user = An<IPrincipal>();
                user.WhenToldTo(u => u.Identity)
                    .Return(new ClaimsIdentity(new[] { new Claim(ApplicationClaimTypes.CustomerId, "99") }));

                var controllerContext = An<ControllerContext>();
                controllerContext.WhenToldTo(c => c.HttpContext.User)
                    .Return(user);

                Subject.ControllerContext = controllerContext;
            };

            Because of = () =>
                _result = Subject.Create(Param.IsAny<CreateClientModel>());

            It should_save_client_and_redirect_to_viewing_client = () =>
            {
                The<IClientService>()
                    .WasToldTo(c => c.SaveClient(Param.IsAny<SaveClientDto>()));

                _result.ShouldRedirectToAction((ClientsController c) => c.Index(Param.IsAny<ClientSearchModel>()));
            };
        }
    }
}