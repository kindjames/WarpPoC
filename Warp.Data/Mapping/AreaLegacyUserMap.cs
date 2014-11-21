using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AreaLegacyUserMap : EntityTypeConfiguration<AreaLegacyUser>
    {
        public AreaLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.AreaLegacyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("AreaLegacyUser", "Migration");
            this.Property(t => t.AreaLegacyId).HasColumnName("AreaLegacyID");
            this.Property(t => t.AreaId).HasColumnName("AreaID");
            this.Property(t => t.LegacyId).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Area)
                .WithMany(t => t.AreaLegacyUsers)
                .HasForeignKey(d => d.AreaId);

        }
    }
}
