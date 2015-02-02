using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class BriefBrandMap : EntityTypeConfiguration<BriefBrand>
    {
        public BriefBrandMap()
        {
            // Primary Key
            HasKey(t => t.BriefBrand1);

            // Properties
            Property(t => t.BriefBrand1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("BriefBrand");
            Property(t => t.BriefBrand1).HasColumnName("BriefBrand");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.Brief)
                .WithMany(t => t.BriefBrands)
                .HasForeignKey(d => d.BriefId);

        }
    }
}
