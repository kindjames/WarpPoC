using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Command;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.Clients;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IServiceLocator _serviceLocator;

        public ClientService(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper, IServiceLocator serviceLocator)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
            _serviceLocator = serviceLocator;
        }

        public IResponse<ClientDto> GetClient(int clientId)
        {
            CheckArgument.NotZero(clientId, "clientId");

            var client = _queryDispatcher.Execute(new GetClientQuery {ClientId = clientId});

            if (client == null)
            {
                throw new DataEntityNotFoundException<Client>(clientId);
            }

            return _objectMapper.Map<Client, ClientDto>(client)
                .ToSuccessfulResponse();
        }

        public IResponse SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");
            
            if (saveClientDto.Id == 0)
            {
                var command = _objectMapper.Map<SaveClientDto, CreateClientCommand>(saveClientDto);

                _commandDispatcher.Execute(command);

                saveClientDto.Id = command.Id;
            }
            else
            {
                var command = _objectMapper.Map<SaveClientDto, UpdateClientCommand>(saveClientDto);

                _commandDispatcher.Execute(command);
            }

            return new ServiceResponse();
        }

        public IResponse<IEnumerable<ClientDto>> GetClients(string clientNameQuery, int customerId)
        {
            CheckArgument.NotZero(customerId, "customerId");
            
            var clients = _queryDispatcher.Execute(new GetClientsQuery
            {
                Query = clientNameQuery,
                CustomerId = customerId
            });

            return _objectMapper.MapMany<Client, ClientDto>(clients)
                .ToSuccessfulResponse();
        }
    }
}