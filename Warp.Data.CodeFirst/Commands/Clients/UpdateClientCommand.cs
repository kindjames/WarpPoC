using Warp.Core.Command;
using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Infrastructure.Validation;
using Warp.Core.Util;
using Warp.Data.Context;
using Warp.Data.Entities;

namespace Warp.Data.Commands.Clients
{
    public sealed class UpdateClientCommand : ICommand
    {
        [IdRequired]
        public int Id { get; set; }

        public string ClientName { get; set; }
        public int CustomerId { get; set; }
        public string ClientCode { get; set; }
        public short ClientStatusId { get; set; }
        public int ClientLegacyId { get; set; }
        public int AccountMangerAdminId { get; set; }
    }

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