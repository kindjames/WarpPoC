using System.Web.Mvc;
using Warp.Core.Infrastructure;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.WebUI.ViewModels.Clients;

namespace Warp.WebUI.Controllers
{
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IObjectMapper _objectMapper;

        public ClientsController(IClientService clientService, IObjectMapper objectMapper)
        {
            _clientService = clientService;
            _objectMapper = objectMapper;
        }

        [Route("{clientId:int}")]
        public ActionResult GetClient(int clientId)
        {
            var client = _clientService.GetClient(clientId);

            var viewModel = _objectMapper.Map<GetClientDto, GetClientViewModel>(client);

            return View(viewModel);
        }
	}
}