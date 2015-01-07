using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Web.Mvc;
using Warp.Core.Authentication;
using Warp.Core.Enum;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.Models.Clients;
using Warp.WebUI.Models.Users;

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
        [ChildActionOnly]
        [Route("list")]
        public ActionResult List(ClientListInputModel model)
        {
            var customerId = User.Identity.GetOrThrowClaimValueFor<int>(ApplicationClaimTypes.CustomerId);

            var response = _clientService.GetClients(model.ClientSearchQuery, customerId);

            var viewModel = _objectMapper.MapMany<ClientDto, ClientModel>(response.Result);

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

                dto.CustomerId = User.Identity.GetOrThrowClaimValueFor<int>(ApplicationClaimTypes.CustomerId);
                dto.AccountManagerId = User.Identity.GetOrThrowClaimValueFor<int>(ClaimTypes.NameIdentifier);

                var response = _clientService.SaveClient(dto);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpGet]
        [Route("{clientId:int}")]
        public ActionResult View(int clientId)
        {
            var response = _clientService.GetClient(clientId);

            var model = _objectMapper.Map<ClientDto, ClientModel>(response.Result);

            return View(model);
        }

        [HttpGet]
        [Route("{clientId:int}")]
        public ActionResult Update(ClientModel model)
        {
            var client = _objectMapper.Map<ClientModel, SaveClientDto>(model);

            _clientService.SaveClient(client);

            return View(model);
        }
    }
}