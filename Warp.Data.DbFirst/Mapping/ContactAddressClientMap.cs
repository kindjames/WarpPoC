using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ContactAddressClientMap : EntityTypeConfiguration<ContactAddressClient>
    {
        public ContactAddressClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressClientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressClient", "Client");
            this.Property(t => t.ContactAddressClientId).HasColumnName("ContactAddressClientID");
            this.Property(t => t.ContactAddressId).HasColumnName("ContactAddressID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.ContactAddressTypeId).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ClientId);

            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressId);

            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressTypeId);
        }
    }
}