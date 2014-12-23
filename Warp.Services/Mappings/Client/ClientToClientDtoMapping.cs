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

            return new ClientDto
            {
                Id = source.Id,
                Code = source.Code,
                Name = source.Name,
                DateValidFrom = source.DateValidFrom,
                CustomerId = source.Customer.Id,
                Status = source.Status
                //AccountManager = source.AccountManager.UserId,
            };
        }
    }
}