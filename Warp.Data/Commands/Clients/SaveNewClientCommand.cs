using System.Collections.Generic;
using Warp.Core.Command;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.ClientAccountManagers;
using Warp.Data.Queries.Clients;

namespace Warp.Data.Commands.Clients
{
    public sealed class SaveNewClientCommand : ICommand
    {
        public class ContactAddressClient
        {
            public int AssignedByAdminId { get; set; }
            public int ContactAddressId { get; set; }
            public int ContactAddressTypeId { get; set; }
        }

        public SaveNewClientCommand()
        {
            ContactAddresses = new List<ContactAddressClient>();
        }

        public string ClientName { get; set; }
        public int CustomerId { get; set; }
        public string ClientCode { get; set; }
        public short ClientStatusId { get; set; }
        public int ClientLegacyId { get; set; }
        public int AccountMangerAdminId { get; set; }
        public IEnumerable<ContactAddressClient> ContactAddresses { get; set; }
    }

    public sealed class SaveNewClientCommandHandler : ICommandHandler<SaveNewClientCommand>
    {
        private readonly IHospitalityGemDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IMappingConfiguration<SaveNewClientCommand, Client> _objectMapper;

        public SaveNewClientCommandHandler(IHospitalityGemDbContext dbContext, IQueryDispatcher queryDispatcher, IMappingConfiguration<SaveNewClientCommand, Client> objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _objectMapper = objectMapper;
        }

        public void Execute(SaveNewClientCommand command)
        {
            CheckArgument.NotNull(command, "command");
            
            // CheckArgument client exists for customer id and client code.
            var clientExistsQuery = new CheckClientExistsForCodeQuery { CustomerId = command.CustomerId, ClientCode = command.ClientCode };

            if (_queryDispatcher.Execute(clientExistsQuery))
            {
                throw new ClientAlreadyExistsException(clientExistsQuery.CustomerId, clientExistsQuery.ClientCode);
            }

            // CheckArgument account manager exists.
            var accountManagerExistsQuery = new CheckClientAccountManagerExistsQuery { AccountManagerId = command.AccountMangerAdminId };

            if (!_queryDispatcher.Execute(accountManagerExistsQuery))
            {
                throw new DataEntityNotFoundException<ClientAccountManager>(command.AccountMangerAdminId);
            }

            var clientEntity = _objectMapper.Map(command);
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();
        }
    }
}