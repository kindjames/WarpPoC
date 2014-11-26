using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionLegacyUserMap : EntityTypeConfiguration<RegionLegacyUser>
    {
        public RegionLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionLegacyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("RegionLegacyUser", "Migration");
            this.Property(t => t.RegionLegacyId).HasColumnName("RegionLegacyID");
            this.Property(t => t.RegionId).HasColumnName("RegionID");
            this.Property(t => t.LegacyId).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.RegionLegacyUsers)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
