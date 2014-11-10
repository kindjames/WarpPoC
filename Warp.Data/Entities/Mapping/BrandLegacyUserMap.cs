using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BrandLegacyUserMap : EntityTypeConfiguration<BrandLegacyUser>
    {
        public BrandLegacyUserMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandLegacyID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BrandLegacyUser", "Migration");
            this.Property(t => t.BrandLegacyID).HasColumnName("BrandLegacyID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.LegacyID).HasColumnName("LegacyID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandLegacyUsers)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
