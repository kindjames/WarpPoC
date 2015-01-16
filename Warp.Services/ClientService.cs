using System;
using System.Collections.Generic;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly IDispatcher _dispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IValidator _validator;

        public ClientService(IDispatcher dispatcher, IObjectMapper objectMapper, IValidator validator)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
            _validator = validator;
        }

        public IResponse<ClientDto> GetClient(Guid clientId)
        {
            CheckArgument.NotEmptyGuid(clientId, "clientId");

            var client = _dispatcher.Execute(new GetEntityQuery<Client> {EntityId = clientId});

            var clientDto = _objectMapper.MapTo<ClientDto>(client);

            return new ServiceResponse<ClientDto>(clientDto);
        }

        public IResponse SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");
            
            _validator.Validate(saveClientDto);

            var command = _objectMapper.MapTo<SaveClientCommand>(saveClientDto);

            _dispatcher.Execute(command);
            
            return new ServiceResponse();
        }

        public IResponse<IEnumerable<ClientDto>> GetClients(string clientNameQuery, Guid customerId)
        {
            CheckArgument.NotEmptyGuid(customerId, "customerId");
            
            var clients = _dispatcher.Execute(new GetClientsQuery
            {
                Query = clientNameQuery,
                CustomerId = customerId
            });

            var clientsDto = _objectMapper.MapMany<Client, ClientDto>(clients);

            return new ServiceResponse<IEnumerable<ClientDto>>(clientsDto);
        }
    }
}