using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class RegionLegacyUserMap : EntityTypeConfiguration<RegionLegacyUser>
    {
        public RegionLegacyUserMap()
        {
            // Primary Key
            HasKey(t => t.RegionLegacyId);

            // Properties
            // Table & Column Mappings
            ToTable("RegionLegacyUser", "Migration");
            Property(t => t.RegionLegacyId).HasColumnName("RegionLegacyID");
            Property(t => t.RegionId).HasColumnName("RegionID");
            Property(t => t.LegacyId).HasColumnName("LegacyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Region)
                .WithMany(t => t.RegionLegacyUsers)
                .HasForeignKey(d => d.RegionId);

        }
    }
}
