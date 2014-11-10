using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ContactAddressClientMap : EntityTypeConfiguration<ContactAddressClient>
    {
        public ContactAddressClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactAddressClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ContactAddressClient", "Client");
            this.Property(t => t.ContactAddressClientID).HasColumnName("ContactAddressClientID");
            this.Property(t => t.ContactAddressID).HasColumnName("ContactAddressID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.ContactAddressTypeID).HasColumnName("ContactAddressTypeID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.ContactAddress)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressID);
            this.HasRequired(t => t.ContactAddressType)
                .WithMany(t => t.ContactAddressClients)
                .HasForeignKey(d => d.ContactAddressTypeID);

        }
    }
}
