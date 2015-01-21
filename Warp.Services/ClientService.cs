using System;
using System.Collections.Generic;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
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
        public ClientService(IDispatcher dispatcher, IObjectMapper objectMapper, IValidator validator)
            : base(dispatcher, objectMapper, validator)
        {
        }

        public IResponse<ClientDto> GetClient(Guid clientId)
        {
            CheckArgument.NotEmptyGuid(clientId, "clientId");

            return ResponseOf<ClientDto>()
                .From(new GetEntityQuery<Client> {EntityId = clientId});
        }

        public IResponse SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");

            return ResponseFrom<SaveClientCommand>()
                .UsingDto(saveClientDto);
        }

        public IResponse<IEnumerable<ClientDto>> GetClients(string clientNameQuery, Guid customerId)
        {
            CheckArgument.NotEmptyGuid(customerId, "customerId");

            return ResponseOfMany<ClientDto>()
                .From(new GetClientsQuery
                {
                    Query = clientNameQuery,
                    CustomerId = customerId
                });
        }
    }
}