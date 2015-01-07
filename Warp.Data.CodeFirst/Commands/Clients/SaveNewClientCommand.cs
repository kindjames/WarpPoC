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
using Warp.Data.Queries.Clients;
using Warp.Data.Validation;

namespace Warp.Data.Commands.Clients
{
    public sealed class SaveNewClientCommand : ICommand
    {
        public int Id { get; internal set; }

        [Required]
        public string Name { get; set; }

        [IdRequired]
        [CheckEntityExists(typeof(Customer))]
        public int CustomerId { get; set; }

        [Required]
        public string Code { get; set; }

        [IdRequired]
        public ClientStatus Status { get; set; }

        [IdRequired]
        [CheckEntityExists(typeof(User))]
        public int AccountManagerId { get; set; }

        public int LegacyClientId { get; set; }
    }

    public sealed class SaveNewClientCommandHandler : ICommandHandler<SaveNewClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;

        public SaveNewClientCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveNewClientCommand command)
        {
            // Check whether client already exists for customer id and client code.
            var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code };

            if (_queryDispatcher.Execute(clientExistsQuery))
            {
                throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            }

            // All systems go!
            var clientEntity = _objectMapper.Map<SaveNewClientCommand, Client>(command);
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();

            // Set the newly-created id in the command.
            command.Id = clientEntity.Id;
        }
    }
}