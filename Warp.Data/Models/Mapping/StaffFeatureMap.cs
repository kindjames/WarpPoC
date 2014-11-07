using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class StaffFeatureMap : EntityTypeConfiguration<StaffFeature>
    {
        public StaffFeatureMap()
        {
            // Primary Key
            this.HasKey(t => t.StaffFeatureID);

            // Properties
            this.Property(t => t.StaffFeatureID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StaffFeature");
            this.Property(t => t.StaffFeatureID).HasColumnName("StaffFeatureID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
