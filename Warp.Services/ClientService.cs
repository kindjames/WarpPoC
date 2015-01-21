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
    public sealed class ClientService : ServiceBase, IClientService
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

            // Generate Query POCO.
            var query = new GetEntityQuery<Client> {EntityId = clientId};

            // Validate POCO.
            var queryValidation = _validator.Validate<GetEntityQuery<Client>, ClientDto>(query);

            if (!queryValidation.Successful)
            {
                // Return failed validation response.
                return queryValidation;
            }

            // Dispatch Query to QueryHandler.
            var client = _dispatcher.Execute(query);

            // Map response to Dto.
            var clientDto = _objectMapper.MapTo<ClientDto>(client);

            // Return successful response.
            return Success(clientDto);
        }

        public IResponse SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");
            
            // Validate Dto.
            var dtoValidation = _validator.Validate(saveClientDto);

            if (!dtoValidation.Successful)
            {
                // Return failed Dto validation response.
                return dtoValidation;
            }

            // Map to Command POCO.
            var command = _objectMapper.MapTo<SaveClientCommand>(saveClientDto);

            // Validate Command POCO.
            var commandValidation = _validator.Validate(command);

            if (!commandValidation.Successful)
            {
                // Return failed Command POCO validation response.
                return commandValidation;
            }

            // Dispatch Command POCO to CommandHandler.
            _dispatcher.Execute(command);

            return Success();
        }

        public IResponse<IEnumerable<ClientDto>> GetClients(string clientNameQuery, Guid customerId)
        {
            CheckArgument.NotEmptyGuid(customerId, "customerId");

            // Create Query POCO.
            var query = new GetClientsQuery
            {
                Query = clientNameQuery,
                CustomerId = customerId
            };

            // Validate Query POCO.
            var queryValidation = _validator.Validate<GetClientsQuery, IEnumerable<ClientDto>>(query);

            if (!queryValidation.Successful)
            {
                // Return failed Query POCO validation response.
                return queryValidation;
            }
            
            // Dispatch Query POCO to QueryHandler.
            var clients = _dispatcher.Execute(query);

            // Map result to DTO.
            var clientsDto = _objectMapper.MapMany<Client, ClientDto>(clients);

            // Return DTO wrapped in IResponse<>.
            return Success(clientsDto);
        }
    }
}