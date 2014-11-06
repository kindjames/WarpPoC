using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerRegionMap : EntityTypeConfiguration<ManagerRegion>
    {
        public ManagerRegionMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerRegionID);

            // Properties
            this.Property(t => t.ManagerRegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ManagerRegion");
            this.Property(t => t.ManagerRegionID).HasColumnName("ManagerRegionID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");

            // Relationships
            this.HasRequired(t => t.Region1)
                .WithMany(t => t.ManagerRegions)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
