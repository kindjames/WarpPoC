using System.ComponentModel.DataAnnotations;
using AutoMapper;
using Warp.Core.Command;
using Warp.Core.Enum;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Commands.Clients
{
    public sealed class SaveNewClientCommand : ICommand
    {
        public int Id { get; internal set; }

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

    public sealed class SaveNewClientCommandHandler : ICommandHandler<SaveNewClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IMappingEngine _mappingEngine;

        public SaveNewClientCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IMappingEngine mappingEngine)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _mappingEngine = mappingEngine;
        }

        public void Execute(SaveNewClientCommand command)
        {
            CheckArgument.NotNull(command, "command");

            // Check client exists for customer id and client code.
            var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code };

            if (_queryDispatcher.Execute(clientExistsQuery))
            {
                throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            }

            //TODO: 
            //var entityExistsQuery = new CheckEntityExistsQuery<

            // Check account manager exists.
            //var accountManagerExistsQuery = new CheckClientAccountManagerExistsQuery { AccountManagerId = command.AccountManagerAdminId };

            //if (!_queryDispatcher.Execute(accountManagerExistsQuery))
            //{
            //    throw new DataEntityNotFoundException<ClientAccountManager>(command.AccountManagerAdminId);
            //}

            var clientEntity = _mappingEngine.Map<SaveNewClientCommand, Client>(command);
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();

            command.Id = clientEntity.Id;
        }
    }
}