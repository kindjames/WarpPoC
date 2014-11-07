using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class RegionLegacyUserMap : EntityTypeConfiguration<RegionLegacyUser>
    {
        public RegionLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionLegacyID);

            // Properties
            // Table & Column Mappings
            this.ToTable("RegionLegacyUser", "Migration");
            this.Property(t => t.RegionLegacyID).HasColumnName("RegionLegacyID");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.LegacyID).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.RegionLegacyUsers)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
