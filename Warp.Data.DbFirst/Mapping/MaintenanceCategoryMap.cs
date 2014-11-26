using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MaintenanceCategoryMap : EntityTypeConfiguration<MaintenanceCategory>
    {
        public MaintenanceCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.MaintenanceCategoryId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MaintenanceCategory");
            this.Property(t => t.MaintenanceCategoryId).HasColumnName("MaintenanceCategoryID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}