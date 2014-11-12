using System.Web.Mvc;
using Warp.Core.Infrastructure;
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

        [HttpGet, Route("create")]
        public ActionResult CreateClient()
        {
            return View("Client", new ClientViewModel());
        }

        [HttpGet, Route("{clientId:int}")]
        public ActionResult GetClient(int clientId)
        {
            var client = _clientService.GetClient(clientId);

            var viewModel = _objectMapper.Map<GetClientDto, ClientViewModel>(client);

            return View("Client", viewModel);
        }

        [HttpPost, Route("{clientId:int?}")]
        public ActionResult SaveClient(ClientInputModel model)
        {
            //if (ModelState.IsValid)
            {
                var dto = _objectMapper.Map<ClientInputModel, SaveClientDto>(model);

                _clientService.SaveClient(dto);

                return RedirectToAction("GetClient", new {clientId = dto.Id});
            }
        }
	}
}