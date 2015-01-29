using System;
using System.Web.Mvc;
using FluentValidation;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Infrastructure;
using Warp.WebUI.ViewModels.Client;

namespace Warp.WebUI.Controllers
{
    [Authorize]
    [RoutePrefix("client")]
    [PopulateTextResourcesOnModel]
    public partial class ClientController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IObjectMapper _objectMapper;

        public ClientController(IClientService clientService, IObjectMapper objectMapper)
        {
            _clientService = clientService;
            _objectMapper = objectMapper;
        }

        [HttpGet]
        public virtual ActionResult Index(ClientSearchModel model)
        {
            return View(model);
        }

        [HttpGet]
        public virtual ActionResult List(ClientListInputModel model)
        {
            var clients = _clientService.GetClients(model.ClientSearchQuery, User.GetCustomerId());

            var viewModel = _objectMapper.MapToMany<ViewClientViewModel>(clients);

            return PartialView(viewModel);
        }

        [HttpGet]
        [Route("create")]
        public virtual ActionResult Create()
        {
            return View(new CreateClientViewModel());
        }

        [HttpPost]
        [Route("create")]
        public virtual ActionResult Create(CreateClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _objectMapper.MapTo<SaveClientDto>(model);
                dto.Id = Guid.NewGuid();
                dto.CustomerId = User.GetCustomerId();
                dto.AccountManagerId = User.GetUserId();

                try
                {
                    _clientService.SaveClient(dto);

                    return RedirectToAction(List());
                }
                catch (ValidationException ex)
                {
                    ModelState.AddValidationException(ex);
                }
            }

            return View(model);
        }

        [HttpGet]
        [Route("{id:guid}/update")]
        public virtual ActionResult Update(Guid id)
        {
            var client = _clientService.GetClient(id);

            var model = _objectMapper.MapTo<UpdateClientViewModel>(client);

            return View(model);
        }

        [HttpPost]
        [Route("{id:guid}/update")]
        public virtual ActionResult Update(UpdateClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var client = _objectMapper.MapTo<SaveClientDto>(model);

                try
                {
                    _clientService.SaveClient(client);
                    return RedirectToAction(List());
                }
                catch (ValidationException ex)
                {
                    ModelState.AddValidationException(ex);
                }
            }

            return View(model);
        }
    }
}