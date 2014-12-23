using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MaintenanceCategoryMap : EntityTypeConfiguration<MaintenanceCategory>
    {
        public MaintenanceCategoryMap()
        {
            // Primary Key
            HasKey(t => t.MaintenanceCategoryId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("MaintenanceCategory");
            Property(t => t.MaintenanceCategoryId).HasColumnName("MaintenanceCategoryID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
