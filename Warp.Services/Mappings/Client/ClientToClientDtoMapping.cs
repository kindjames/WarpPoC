using Warp.Core.Infrastructure.Mapping;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;

namespace Warp.Services.Mappings.Client
{
    public sealed class ClientToClientDtoMapping : IMappingConfiguration<Data.Entities.Client, ClientDto>
    {
        public ClientDto Map(Data.Entities.Client source)
        {
            CheckArgument.NotNull(source, "source");
            CheckArgument.NotNull(source.AccountManager, "source.AccountManager");
            CheckArgument.NotNull(source.Customer, "source.Customer");
            CheckArgument.NotNull(source.ClientStatus, "source.ClientStatus");

            return new ClientDto
            {
                ClientId = source.ClientId,
                Code = source.Code,
                Name = source.Name,
                DateValidFrom = source.DateValidFrom,
                AccountManagerId = source.AccountManager.UserId,
                AccountManagerName = source.AccountManager.Forename + " " + source.AccountManager.Surname,
                CustomerId = source.Customer.CustomerId,
                ClientStatusId = source.ClientStatus.ClientStatusId,
                ClientStatusDescription = source.ClientStatus.Description,
            };
        }
    }
}