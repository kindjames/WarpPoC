using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandLegacyUserMap : EntityTypeConfiguration<BrandLegacyUser>
    {
        public BrandLegacyUserMap()
        {
            // Primary Key
            HasKey(t => t.BrandLegacyId);

            // Properties
            // Table & Column Mappings
            ToTable("BrandLegacyUser", "Migration");
            Property(t => t.BrandLegacyId).HasColumnName("BrandLegacyID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.LegacyId).HasColumnName("LegacyID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BrandLegacyUsers)
                .HasForeignKey(d => d.BrandId);

        }
    }
}
