using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandLegacyUserMap : EntityTypeConfiguration<BrandLegacyUser>
    {
        public BrandLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandLegacyId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BrandLegacyUser", "Migration");
            this.Property(t => t.BrandLegacyId).HasColumnName("BrandLegacyID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.LegacyId).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandLegacyUsers)
                .HasForeignKey(d => d.BrandId);

        }
    }
}
