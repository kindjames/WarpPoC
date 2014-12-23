using System.Security.Claims;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Warp.Core.Authentication;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Models.Clients;

namespace Warp.WebUI.Controllers
{
    [Authorize]
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
        public ActionResult Index(ClientSearchModel model)
        {
            return View(model);
        }

        [HttpGet]
        [Route("list")]
        public ActionResult List(ClientListInputModel model)
        {
            var customerId = User.Identity.GetOrThrowClaimValueFor<int>(ApplicationClaimTypes.CustomerId);

            var clients = _clientService.GetClients(model.ClientSearchQuery, customerId);

            var viewModel = _objectMapper.MapMany<ClientDto, ClientModel>(clients);

            return PartialView(viewModel);
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new CreateClientModel());
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(CreateClientModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _objectMapper.Map<CreateClientModel, SaveClientDto>(model);

                dto.Customer = User.Identity.GetOrThrowClaimValueFor<int>(ApplicationClaimTypes.CustomerId);
                dto.AccountManager = User.Identity.GetOrThrowClaimValueFor<int>(ClaimTypes.NameIdentifier);

                _clientService.SaveClient(dto);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        [Route("{clientId:int}")]
        public ActionResult View(int clientId)
        {
            var client = _clientService.GetClient(clientId);

            var model = _objectMapper.Map<ClientDto, ClientModel>(client);

            return View(model);
        }
    }
}