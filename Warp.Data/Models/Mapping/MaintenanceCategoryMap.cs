using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MaintenanceCategoryMap : EntityTypeConfiguration<MaintenanceCategory>
    {
        public MaintenanceCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceCategoryID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaintenanceCategory");
            this.Property(t => t.MaintenanceCategoryID).HasColumnName("MaintenanceCategoryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
