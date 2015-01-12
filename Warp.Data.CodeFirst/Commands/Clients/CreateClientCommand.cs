using System;
using System.ComponentModel.DataAnnotations;
using Warp.Core.Command;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.Clients;
using Warp.Data.Queries.General;

namespace Warp.Data.Commands.Clients
{
    public class CreateClientCommand : CreateCommandBase
    {
        [Required]
        public string Name { get; set; }

        [IdRequired]
        public int CustomerId { get; set; }

        [Required]
        public string Code { get; set; }

        [IdRequired]
        public ClientStatus Status { get; set; }

        [IdRequired]
        public int AccountManagerId { get; set; }

        public int LegacyClientId { get; set; }
    }

    public class CreateClientCommandHandler : ICommandHandler<CreateClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public CreateClientCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(CreateClientCommand command)
        {
            // Check whether client already exists for customer id and client code.
            var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code };
            
            if (_queryDispatcher.Execute(clientExistsQuery))
            {
                throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            }

            // Validate Account Manager (user) exists.
            if (!_queryDispatcher.Execute(new CheckEntityExistsQuery<User> { EntityId = command.AccountManagerId }))
            {
                throw new DataEntityNotFoundException<User>(command.AccountManagerId, "Looking for Account Manager.");
            }

            // Validate customer exists.
            if (!_queryDispatcher.Execute(new CheckEntityExistsQuery<Customer> { EntityId = command.CustomerId }))
            {
                throw new DataEntityNotFoundException<Customer>(command.CustomerId);
            }

            // All systems go!
            var clientEntity = _objectMapper.Map<CreateClientCommand, Client>(command);
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();

            // Set the newly-created id in the command.
            command.Id = clientEntity.Id;
        }
    }
}