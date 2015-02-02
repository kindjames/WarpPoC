using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BrandLogoMap : EntityTypeConfiguration<BrandLogo>
    {
        public BrandLogoMap()
        {
            // Primary Key
            HasKey(t => t.BrandLogoId);

            // Properties
            // Table & Column Mappings
            ToTable("BrandLogo", "Client");
            Property(t => t.BrandLogoId).HasColumnName("BrandLogoID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.LogoId).HasColumnName("LogoID");
            Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            Property(t => t.Created).HasColumnName("Created");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Logo)
                .WithMany(t => t.BrandLogoes)
                .HasForeignKey(d => d.LogoId);

        }
    }
}
