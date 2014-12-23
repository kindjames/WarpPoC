using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressClientMap : EntityTypeConfiguration<ContactAddressClient>
    {
        public ContactAddressClientMap()
        {
            // Primary Key
            HasKey(t => t.ContactAddressClientId);

            // Properties
            // Table & Column Mappings
            ToTable("ContactAddressClient", "Client");
            Property(t => t.ContactAddressClientId).HasColumnName("ContactAddressClientID");
            Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ClientId);

            HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressId);

            HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressTypeId);
        }
    }
}