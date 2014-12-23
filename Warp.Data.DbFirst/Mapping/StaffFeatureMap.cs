using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class StaffFeatureMap : EntityTypeConfiguration<StaffFeature>
    {
        public StaffFeatureMap()
        {
            // Primary Key
            HasKey(t => t.StaffFeatureId);

            // Properties
            Property(t => t.StaffFeatureId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("StaffFeature");
            Property(t => t.StaffFeatureId).HasColumnName("StaffFeatureID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
