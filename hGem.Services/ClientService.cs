using System;
using System.Collections.Generic;
using hGem.Core.Cqrs;
using hGem.Core.Exceptions;
using hGem.Core.Infrastructure.AutoMapper;
using hGem.Core.Infrastructure.Util;
using hGem.Core.Infrastructure.Validation;
using hGem.Core.Services;
using hGem.Core.Services.Dtos.Client;
using hGem.Data.Commands.Clients;
using hGem.Data.Entities;
using hGem.Data.Queries.Clients;
using hGem.Data.Queries.General;

namespace hGem.Services
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
            
            var result = _dispatcher.Execute(new GetEntityQuery<Client> { EntityId = clientId });

            return _objectMapper.MapTo<ClientDto>(result);
        }

        public void SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");

            _validationProvider.ValidateAndThrow(saveClientDto);

            if (_dispatcher.Execute(new CheckClientExistsForCodeQuery { CustomerId = saveClientDto.CustomerId, ClientCode = saveClientDto.Code }))
            {
                throw new ClientAlreadyExistsException(saveClientDto.CustomerId, saveClientDto.Code);
            }

            var command = _objectMapper.MapTo<SaveClientCommand>(saveClientDto);

            _dispatcher.Execute(command);
        }

        public IEnumerable<ClientDto> GetClients(string clientNameQuery, Guid customerId)
        {
            CheckArgument.NotEmptyGuid(customerId, "customerId");

            var result = _dispatcher.Execute(new GetClientsQuery
            {
                Query = clientNameQuery,
                CustomerId = customerId
            });

            return _objectMapper.MapToMany<ClientDto>(result);
        }
    }
}