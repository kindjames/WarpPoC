using System;
using System.Collections.Generic;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
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
        private readonly IValidationProvider _validationProvider;

        public ClientService(IDispatcher dispatcher, IObjectMapper objectMapper, IValidationProvider validationProvider)
        {
            _dispatcher = dispatcher;
            _objectMapper = objectMapper;
            _validationProvider = validationProvider;
        }

        public ClientDto GetClient(Guid clientId)
        {
            CheckArgument.NotEmptyGuid(clientId, "clientId");

            var query = new GetEntityQuery<Client> {EntityId = clientId};

            // Validate POCO.
            _validationProvider.ValidateAndThrow(query);

            // Dispatch Query to QueryHandler.
            var result = _dispatcher.Execute(query);

            // Map response to Dto.
            return _objectMapper.MapTo<ClientDto>(result);
        }

        public void SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");

            // Validate Dto.
            _validationProvider.ValidateAndThrow(saveClientDto);

            var command = _objectMapper.MapTo<SaveClientCommand>(saveClientDto);

            // Validate Command POCO.
            _validationProvider.ValidateAndThrow(command);

            // Dispatch Command POCO to CommandHandler.
            _dispatcher.Execute(command);
        }

        public IEnumerable<ClientDto> GetClients(string clientNameQuery, Guid customerId)
        {
            CheckArgument.NotEmptyGuid(customerId, "customerId");

            var query = new GetClientsQuery
            {
                Query = clientNameQuery,
                CustomerId = customerId
            };

            // Validate POCO.
            _validationProvider.ValidateAndThrow(query);

            // Dispatch Query to QueryHandler.
            var result = _dispatcher.Execute(query);

            // Map response to Dto.
            return _objectMapper.MapToMany<ClientDto>(result);
        }
    }
}