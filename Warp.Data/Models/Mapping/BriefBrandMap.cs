using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class BriefBrandMap : EntityTypeConfiguration<BriefBrand>
    {
        public BriefBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.BriefBrand1);

            // Properties
            this.Property(t => t.BriefBrand1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("BriefBrand");
            this.Property(t => t.BriefBrand1).HasColumnName("BriefBrand");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BriefID);

        }
    }
}
