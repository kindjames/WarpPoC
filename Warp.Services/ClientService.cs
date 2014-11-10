using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;

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
            CheckArgument.NotNull(saveClientDto, "saveClientDto");

            ICommand command;

            if (saveClientDto.Id == 0)
            {
                command = _objectMapper.Map<SaveClientDto, SaveNewClientCommand>(saveClientDto);
            }
            else
            {
                command = _objectMapper.Map<SaveClientDto, UpdateClientCommand>(saveClientDto);
            }
            
            _commandDispatcher.Execute(command);
        }
    }
}