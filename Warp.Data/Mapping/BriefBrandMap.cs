using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
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
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.BriefId).HasColumnName("BriefID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
