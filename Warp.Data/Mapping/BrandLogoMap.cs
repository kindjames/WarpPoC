using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class BrandLogoMap : EntityTypeConfiguration<BrandLogo>
    {
        public BrandLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandLogoId);

            // Properties
            // Table & Column Mappings
            this.ToTable("BrandLogo", "Client");
            this.Property(t => t.BrandLogoId).HasColumnName("BrandLogoID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.LogoId).HasColumnName("LogoID");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.BrandLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
