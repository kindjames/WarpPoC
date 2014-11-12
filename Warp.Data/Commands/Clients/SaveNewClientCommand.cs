﻿using System;
using System.Collections.Generic;
using Warp.Core.Command;
using Warp.Core.Exceptions;
using Warp.Core.Infrastructure;
using Warp.Core.Query;
using Warp.Core.Util;
using Warp.Core.Validation;
using Warp.Data.Context;
using Warp.Data.Entities;
using Warp.Data.Exceptions;
using Warp.Data.Queries.ClientAccountManagers;
using Warp.Data.Queries.Clients;
using System.ComponentModel.DataAnnotations;

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

        public IEnumerable<ContactAddressClient> ContactAddresses { get; set; }

        public SaveNewClientCommand()
        {
            ContactAddresses = new List<ContactAddressClient>();
        }

        public int ClientId { get; private set; }

        public void SetClientId(int id)
        {
            ClientId = id;
        }
    }

    public sealed class SaveNewClientCommandHandler : ICommandHandler<SaveNewClientCommand>
    {
        private readonly IHospitalityGemDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IObjectMapper _objectMapper;
        private readonly IDateTimeProvider _dateTimeProvider;

        public SaveNewClientCommandHandler(IHospitalityGemDbContext dbContext, IQueryDispatcher queryDispatcher, IObjectMapper objectMapper, IDateTimeProvider dateTimeProvider)
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
            var accountManagerExistsQuery = new CheckClientAccountManagerExistsQuery { AccountManagerId = command.AccountManagerAdminId };

            if (!_queryDispatcher.Execute(accountManagerExistsQuery))
            {
                throw new DataEntityNotFoundException<ClientAccountManager>(command.AccountManagerAdminId);
            }

            var clientEntity = _objectMapper.Map<SaveNewClientCommand, Client>(command);

            clientEntity.DateCreated = _dateTimeProvider.UtcNow();
            clientEntity.DateUpdated = _dateTimeProvider.UtcNow();
            clientEntity.DateValidFrom = _dateTimeProvider.UtcNow();
            clientEntity.Active = true;
            
            _dbContext.Clients.Add(clientEntity);

            _dbContext.SaveChanges();

            command.SetClientId(clientEntity.ClientID);
        }
    }
}