using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
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
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BrandLegacyUsers)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
