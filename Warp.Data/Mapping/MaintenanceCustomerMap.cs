using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MaintenanceCustomerMap : EntityTypeConfiguration<MaintenanceCustomer>
    {
        public MaintenanceCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceCustomerId);

            // Properties
            // Table & Column Mappings
            this.ToTable("MaintenanceCustomer");
            this.Property(t => t.MaintenanceCustomerId).HasColumnName("MaintenanceCustomerID");
            this.Property(t => t.CustomerId).HasColumnName("CustomerID");
            this.Property(t => t.MaintenanceId).HasColumnName("MaintenanceID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.CustomerId);
            this.HasRequired(t => t.Maintenance)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.MaintenanceId);

        }
    }
}
