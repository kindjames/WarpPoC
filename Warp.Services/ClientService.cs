using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Models;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IObjectMapper _objectMapper;

        public ClientService(ICommandDispatcher commandDispatcher, IObjectMapper objectMapper)
        {
            _commandDispatcher = commandDispatcher;
            _objectMapper = objectMapper;
        }

        public void SaveClient(SaveClientDto saveClientDto)
        {
            Check.NotNull(saveClientDto, "saveClientDto");

            var client = _objectMapper.Map<SaveClientDto, Client>(saveClientDto);

            _commandDispatcher.Execute(new SaveClientCommand { Client = client });
        }
    }
}