using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MaintenanceCustomerMap : EntityTypeConfiguration<MaintenanceCustomer>
    {
        public MaintenanceCustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceCustomerID);

            // Properties
            // Table & Column Mappings
            this.ToTable("MaintenanceCustomer");
            this.Property(t => t.MaintenanceCustomerID).HasColumnName("MaintenanceCustomerID");
            this.Property(t => t.CustomerID).HasColumnName("CustomerID");
            this.Property(t => t.MaintenanceID).HasColumnName("MaintenanceID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Customer)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.CustomerID);
            this.HasRequired(t => t.Maintenance)
                .WithMany(t => t.MaintenanceCustomers)
                .HasForeignKey(d => d.MaintenanceID);

        }
    }
}
