using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
    public sealed class UpdateClientCommand : ICommand
    {
        public class ContactAddressClient
        {
            public int AssignedByAdminId { get; set; }
            public int ContactAddressId { get; set; }
            public int ContactAddressTypeId { get; set; }
        }

        public UpdateClientCommand()
        {
            ContactAddresses = new List<ContactAddressClient>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int CustomerId { get; set; }
        public string ClientCode { get; set; }
        public short ClientStatusId { get; set; }
        public int ClientLegacyId { get; set; }
        public int AccountMangerAdminId { get; set; }
        public IEnumerable<ContactAddressClient> ContactAddresses { get; set; }
    }

    public sealed class UpdateClientCommandHandler : ICommandHandler<UpdateClientCommand>
    {
        private readonly IHospitalityGemDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IObjectMapper _objectMapper;

        public UpdateClientCommandHandler(IHospitalityGemDbContext dbContext, IQueryDispatcher queryDispatcher, IDateTimeProvider dateTimeProvider, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _dateTimeProvider = dateTimeProvider;
            _objectMapper = objectMapper;
        }

        public void Execute(UpdateClientCommand command)
        {
            CheckArgument.NotNull(command, "command");
        }
    }
}