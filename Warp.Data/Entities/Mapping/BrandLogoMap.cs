using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class BrandLogoMap : EntityTypeConfiguration<BrandLogo>
    {
        public BrandLogoMap()
        {
            // Primary Key
            this.HasKey(t => t.BrandLogoID);

            // Properties
            // Table & Column Mappings
            this.ToTable("BrandLogo", "Client");
            this.Property(t => t.BrandLogoID).HasColumnName("BrandLogoID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.LogoID).HasColumnName("LogoID");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Logo)
                .WithMany(t => t.BrandLogoes)
                .HasForeignKey(d => d.LogoID);

        }
    }
}
