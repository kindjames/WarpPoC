using System.Linq;
using Warp.Core.Infrastructure;
using Warp.Core.Services.Dtos.Client;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;

namespace Warp.Services.Mappings
{
    public sealed class SaveClientDtoToSaveClientCommandMapping : IMappingConfiguration<SaveClientDto, SaveNewClientCommand>
    {
        public SaveNewClientCommand Map(SaveClientDto source)
        {
            Check.NotNull(source, "source");

            return new SaveNewClientCommand
            {
                ClientCode = source.Code,
                ClientName = source.Name,
                ClientLegacyId = source.LegacyId,
                AccountMangerAdminId = source.AccountManagerId,
                CustomerId = source.CustomerId,
                ClientStatusId = source.StatusId,
                ContactAddresses = source.ContactAddresses.Select(a => new SaveNewClientCommand.ContactAddressClient
                {
                    ContactAddressId = a.ContactAddressId,
                    ContactAddressTypeId = a.ContactAddressTypeId,
                }),
            };
        }
    }
}