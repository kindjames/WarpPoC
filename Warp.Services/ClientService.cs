using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Command;
using Warp.Core.Exceptions.Data;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.IoC;
using Warp.Core.Operations;
using Warp.Core.Query;
using Warp.Core.Services;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Entities;
using Warp.Data.Operations.Command.Clients;
using Warp.Data.Operations.Query;
using Warp.Data.Queries.Clients;

namespace Warp.Services
{
    public sealed class ClientService : IClientService
    {
        private readonly ICommandDispatcher _commandDispatcher;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IServiceLocator _serviceLocator;
        private readonly IOperationFactory _operationFactory;

        public ClientService(ICommandDispatcher commandDispatcher, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper, IServiceLocator serviceLocator, IOperationFactory operationFactory)
        {
            _commandDispatcher = commandDispatcher;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
            _serviceLocator = serviceLocator;
            _operationFactory = operationFactory;
        }

        public IResponse<ClientDto> GetClient(Guid clientId)
        {
            CheckArgument.NotEmptyGuid(clientId, "clientId");

            var getClientResponse = _operationFactory
                .Build<IGetEntityQuery<Client>, Client>()
                .WithParameters(q => q.EntityId = Guid.NewGuid())
                .ValidateAndExecute();
            
            if (getClientResponse.Result == null)
            {
                throw new DataEntityNotFoundException<Client>(clientId);
            }

            return getClientResponse.ToDtoResponse();
        }

        public IResponse SaveClient(SaveClientDto saveClientDto)
        {
            CheckArgument.NotNull(saveClientDto, "saveClientDto");

            var result = _operationFactory
                .Build<ISaveClientCommand>()
                .FromValidDto(saveClientDto)
                .ValidateAndExecute();
            
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