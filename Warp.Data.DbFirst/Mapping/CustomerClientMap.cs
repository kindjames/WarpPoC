using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CustomerClientMap : EntityTypeConfiguration<CustomerClient>
    {
        public CustomerClientMap()
        {
            // Primary Key
            HasKey(t => t.CustomerClientId);

            // Properties
            // Table & Column Mappings
            ToTable("CustomerClient");
            Property(t => t.CustomerClientId).HasColumnName("CustomerClientID");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.CustomerLinkStatusId).HasColumnName("CustomerLinkStatusID");
            Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerId);
            HasRequired(t => t.CustomerLinkStatus)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerLinkStatusId);

        }
    }
}
