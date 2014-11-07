using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CustomerClientMap : EntityTypeConfiguration<CustomerClient>
    {
        public CustomerClientMap()
        {
            // Primary Key
            this.HasKey(t => t.CustomerClientID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CustomerClient");
            this.Property(t => t.CustomerClientID).HasColumnName("CustomerClientID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.CustomerLinkStatusID).HasColumnName("CustomerLinkStatusID");
            this.Property(t => t.PrimaryCustomer).HasColumnName("PrimaryCustomer");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerID);
            this.HasRequired(t => t.CustomerLinkStatu)
                .WithMany(t => t.CustomerClients)
                .HasForeignKey(d => d.CustomerLinkStatusID);

        }
    }
}
