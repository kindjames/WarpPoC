using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Data.Commands.Clients;
using Warp.Data.Models;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IMapper _mapper;

        public ClientService(ICommandDispatcher commandDispatcher, IMapper mapper)
        {
            _commandDispatcher = commandDispatcher;
            _mapper = mapper;
        }

        public void SaveClient(SaveClientDto dto)
        {
            var client = _mapper.Map<Client>(dto);

            _commandDispatcher.Execute(new SaveClientCommand { Client = client });
        }
    }
}