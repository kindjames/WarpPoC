using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MaintenanceCustomerMap : EntityTypeConfiguration<MaintenanceCustomer>
    {
        public MaintenanceCustomerMap()
        {
            // Primary Key
            HasKey(t => t.MaintenanceCustomerId);

            // Properties
            // Table & Column Mappings
            ToTable("MaintenanceCustomer");
            Property(t => t.MaintenanceCustomerId).HasColumnName("MaintenanceCustomerID");
            Property(t => t.CustomerId).HasColumnName("CustomerID");
            Property(t => t.MaintenanceId).HasColumnName("MaintenanceID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Customer)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.CustomerId);
            HasRequired(t => t.Maintenance)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.MaintenanceId);

        }
    }
}
