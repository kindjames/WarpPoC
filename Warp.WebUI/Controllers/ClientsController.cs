using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Web.Mvc;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Models.Clients;

namespace Warp.WebUI.Controllers
{
    [RoutePrefix("clients")]
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IObjectMapper _objectMapper;

        public ClientsController(IClientService clientService, IObjectMapper objectMapper)
        {
            _clientService = clientService;
            _objectMapper = objectMapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new ClientSearchViewModel());
        }

        [HttpGet]
        public ActionResult List(string clientName)
        {
            var clients = _clientService.GetClients(clientName, User.Identity.GetUserId<int>(), -99);

            var model = _objectMapper.Map<IEnumerable<ClientDto>, ClientListViewModel>(clients);

            return PartialView(model);
        }

        [HttpGet, Route("create")]
        public ActionResult Create()
        {
            return View(new ClientViewModel());
        }

        [HttpPost, Route("create")]
        public ActionResult Create(ClientViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _objectMapper.Map<ClientViewModel, SaveClientDto>(model);

                _clientService.SaveClient(dto);

                return RedirectToAction("View", new { clientId = dto.Id });
            }

            return View(model);
        }

        [HttpGet, Route("{clientId:int}")]
        public ActionResult View(int clientId)
        {
            var client = _clientService.GetClient(clientId);

            var viewModel = _objectMapper.Map<ClientDto, ClientViewModel>(client);

            return View(viewModel);
        }
	}
}