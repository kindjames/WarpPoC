using System;
using System.Web.Mvc;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Logging;
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
        private readonly ILoggingService _loggingService;

        public ClientController(IClientService clientService, IObjectMapper objectMapper, ILoggingService loggingService)
        {
            _clientService = clientService;
            _objectMapper = objectMapper;
            _loggingService = loggingService;
        }

        [HttpGet]
        [Route("list")]
        public virtual ActionResult Index(ClientSearchModel model)
        {
            return View(model);
        }

        [HttpGet]
        [ChildActionOnly]
        public virtual ActionResult List(ClientListInputModel model)
        {
            var response = _clientService.GetClients(model.ClientSearchQuery, User.GetCustomerId());

            var viewModel = _objectMapper.MapToMany<ViewClientViewModel>(response.Result);

            return PartialView(viewModel);
        }

        [HttpGet]
        [Route("{clientId:guid}")]
        public virtual ActionResult View(Guid clientId)
        {
            try
            {
                var response = _clientService.GetClient(clientId);

                if (response.Successful)
                {
                    var model = _objectMapper.MapTo<ViewClientViewModel>(response.Result);

                    return View(model);
                }
            }
            catch (DataEntityNotFoundException ex)
            {
                _loggingService.Warn(ex);
                return HttpNotFound();
            }

            return View();
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

                dto.CustomerId = User.GetCustomerId();
                dto.AccountManagerId = User.GetUserId();

                var response = _clientService.SaveClient(dto);

                if (response.Successful)
                {
                    return RedirectToAction("Index");
                }

                ModelState.AddErrorsFromResponse(response);
            }

            return View(model);
        }

        [HttpGet]
        [Route("{clientId:guid}/update")]
        public virtual ActionResult Update(Guid clientId)
        {
            try
            {
                var response = _clientService.GetClient(clientId);

                if (response.Successful)
                {
                    var model = _objectMapper.MapTo<UpdateClientViewModel>(response.Result);

                    return View(model);
                }
            }
            catch (DataEntityNotFoundException ex)
            {
                _loggingService.Warn(ex);
                return HttpNotFound();
            }

            return View();
        }

        [HttpPost]
        [Route("{clientId:guid}/update")]
        public virtual ActionResult Update(UpdateClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var client = _objectMapper.MapTo<SaveClientDto>(model);

                var response = _clientService.SaveClient(client);

                if (response.Successful)
                {
                    return RedirectToAction("View", new {clientId = client.Id});
                }

                ModelState.AddErrorsFromResponse(response);
            }

            return View(model);
        }
    }
}