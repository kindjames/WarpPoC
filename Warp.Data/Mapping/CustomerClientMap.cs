using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CustomerClientMap : EntityTypeConfiguration<CustomerClient>
    {
        public CustomerClientMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerClientId);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerClient");
            this.Property(t => t.CustomerClientId).HasColumnName("CustomerClientID");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.CustomerLinkStatus)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerLinkStatusId);

        }
    }
}
