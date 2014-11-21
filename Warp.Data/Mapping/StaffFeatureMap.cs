using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class StaffFeatureMap : EntityTypeConfiguration<StaffFeature>
    {
        public StaffFeatureMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffFeatureId);

            // Properties
            this.Property(t => t.StaffFeatureId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffFeature");
            this.Property(t => t.StaffFeatureId).HasColumnName("StaffFeatureID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
