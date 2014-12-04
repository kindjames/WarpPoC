using System.ComponentModel.DataAnnotations;
using Warp.Core.Command;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Commands.Clients
{
    public sealed class SaveNewClientCommand : ICommand
    {
        [Required]
        public string Name { get; set; }

        [IdRequired]
        public int CustomerId { get; set; }

        [Required]
        public string Code { get; set; }

        [IdRequired]
        public short ClientStatusId { get; set; }

        [IdRequired]
        public int AccountManagerAdminId { get; set; }

        public int LegacyClientId { get; set; }

        public int ClientId { get; private set; }

        public void SetClientId(int id)
        {
            ClientId = id;
        }
    }

    public sealed class SaveNewClientCommandHandler : ICommandHandler<SaveNewClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IDateTimeProvider _dateTimeProvider;

        public SaveNewClientCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper, IDateTimeProvider dateTimeProvider)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
            _dateTimeProvider = dateTimeProvider;
        }

        public void Execute(SaveNewClientCommand command)
        {
            CheckArgument.NotNull(command, "command");

            // CheckArgument client exists for customer id and client code.
            var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.Code };

            if (_queryDispatcher.Execute(clientExistsQuery))
            {
                throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            }

            // CheckArgument account manager exists.
            //var accountManagerExistsQuery = new CheckClientAccountManagerExistsQuery { AccountManagerId = command.AccountManagerAdminId };

            //if (!_queryDispatcher.Execute(accountManagerExistsQuery))
            //{
            //    throw new DataEntityNotFoundException<ClientAccountManager>(command.AccountManagerAdminId);
            //}

            var clientEntity = _objectMapper.Map<SaveNewClientCommand, Client>(command);
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();

            command.SetClientId(clientEntity.ClientId);
        }
    }
}