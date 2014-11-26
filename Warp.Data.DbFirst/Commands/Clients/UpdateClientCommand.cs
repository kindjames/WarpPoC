using System.Collections.Generic;
using Warp.Core.Command;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Query;
using Warp.Core.Util;
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

        [IdRequired]
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
        private readonly IDomainDbContext _dbContext;
        private readonly IQueryDispatcher _queryDispatcher;
        private readonly IDateTimeProvider _dateTimeProvider;
        private readonly IObjectMapper _objectMapper;

        public UpdateClientCommandHandler(IDomainDbContext dbContext, IQueryDispatcher queryDispatcher, IDateTimeProvider dateTimeProvider, IObjectMapper objectMapper)
        {
            _dbContext = dbContext;
            _queryDispatcher = queryDispatcher;
            _dateTimeProvider = dateTimeProvider;
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