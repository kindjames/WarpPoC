using System.Linq;
using Warp.Core.Infrastructure;
using Warp.Core.Util;
using Warp.Data.Commands.Clients;
using Warp.Data.Entities;

namespace Warp.Services.Mappings
{
    public sealed class SaveClientCommandToClientMapping : IMappingConfiguration<SaveNewClientCommand, Client>
    {
        private readonly IDateTimeProvider _dateTimeProvider;

        public SaveClientCommandToClientMapping(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public Client Map(SaveNewClientCommand source)
        {
            Check.NotNull(source, "source");

            var now = _dateTimeProvider.UtcNow();

            var client = new Client
            {
                Name = source.ClientName,
                CustomerID = source.CustomerId,
                ClientStatusID = source.ClientStatusId,
                Code = source.ClientCode,
                DateCreated = now,
                DateUpdated = now,
                Active = true,
                ContactAddressClients = source.ContactAddresses.Select(a => new ContactAddressClient
                {
                    //TODO: address.AssignedByAdminId is not being set to anything.
                    ContactAddressID = a.ContactAddressId,
                    ContactAddressTypeID = a.ContactAddressTypeId,
                    DateValidFrom = now,
                    DateValidTo = null,
                    DateUpdated = now,
                    DateCreated = now,
                    Active = true
                }).ToList()
            };

            // Add many-to-many map between account manager and client.
            client.ClientAccountManagers.Add(new ClientAccountManager
            {
                AccountManagerID = source.AccountMangerAdminId,
                DateUpdated = now,
                DateCreated = now,
                Active = true
            });

            client.ClientLegacyUsers.Add(new ClientLegacyUser
            {
                LegacyID = source.ClientLegacyId,
                DateUpdated = now,
                DateCreated = now,
                Active = true
            });

            return client;
        }
    }
}