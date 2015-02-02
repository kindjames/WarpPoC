using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AreaLegacyUserMap : EntityTypeConfiguration<AreaLegacyUser>
    {
        public AreaLegacyUserMap()
        {
            // Primary Key
            HasKey(t => t.AreaLegacyId);

            // Properties
            // Table & Column Mappings
            ToTable("AreaLegacyUser", "Migration");
            Property(t => t.AreaLegacyId).HasColumnName("AreaLegacyID");
            Property(t => t.AreaId).HasColumnName("AreaID");
            Property(t => t.LegacyId).HasColumnName("LegacyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Area)
                .WithMany(t => t.AreaLegacyUsers)
                .HasForeignKey(d => d.AreaId);

        }
    }
}
