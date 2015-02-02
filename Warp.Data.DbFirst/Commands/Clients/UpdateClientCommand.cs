using System;
using System.Collections.Generic;
using Warp.Core.Cqrs;
using Warp.Core.Infrastructure.AutoMapper;
using Warp.Core.Infrastructure.General;
using Warp.Core.Infrastructure.Util;
using Warp.Core.Infrastructure.Validation;
using Warp.Data.DbFirst.Context;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Commands.Clients
{
    public sealed class UpdateClientCommand : ICommand
    {
        public UpdateClientCommand()
        {
            ContactAddresses = new List<ContactAddressClient>();
        }

        [NotEmptyGuid]
        public Guid Id { get; set; }
        
        public string ClientName { get; set; }
        public int CustomerId { get; set; }
        public string ClientCode { get; set; }
        public short ClientStatusId { get; set; }
        public int ClientLegacyId { get; set; }
        public int AccountMangerAdminId { get; set; }
        public IEnumerable<ContactAddressClient> ContactAddresses { get; set; }
    }

    public class UpdateClientCommand

    public sealed class UpdateClientCommandHandler : ICommandHandler<UpdateClientCommand>
    {
        private readonly IDomainDbContext _dbContext;
        private readonly IObjectMapper _objectMapper;

        public UpdateClientCommandHandler(IDomainDbContext dbContext, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _objectMapper = objectMapper;
        }

        public void Execute(UpdateClientCommand command)
        {
            CheckArgument.NotNull(command, "command");

            var clientEntity = _objectMapper.Map<UpdateClientCommand, Client>(command);

            _dbContext.Clients.Attach(clientEntity);

            _dbContext.SaveChanges();
        }
    }
}