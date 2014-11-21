﻿using Warp.Core.Command;
using Warp.Core.Infrastructure;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.Clients;
using Client = Warp.Data.Entities.Client;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public ClientService(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public GetClientDto GetClient(int clientId)
        {
            CheckArgument.NotZero(clientId, "clientId");

            var client = _queryDispatcher.Execute(new GetClientQuery {ClientId = clientId});

            if (client == null)
            {
                throw new DataEntityNotFoundException<Client>(clientId);
            }

            return _objectMapper.Map<Client, GetClientDto>(client);
        }

        public void SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");
            
            if (saveClientDto.Id == 0)
            {
                var command = _objectMapper.Map<SaveClientDto, SaveNewClientCommand>(saveClientDto);

                _commandDispatcher.Execute(command);

                saveClientDto.Id = command.ClientId;
            }
            else
            {
                var command = _objectMapper.Map<SaveClientDto, UpdateClientCommand>(saveClientDto);

                _commandDispatcher.Execute(command);
            }
        }
    }
}