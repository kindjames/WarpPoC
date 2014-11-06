using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerBrandMap : EntityTypeConfiguration<ManagerBrand>
    {
        public ManagerBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerBrand1);

            // Properties
            // Table & Column Mappings
            this.ToTable("ManagerBrand");
            this.Property(t => t.ManagerBrand1).HasColumnName("ManagerBrand");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");

            // Relationships
            this.HasRequired(t => t.Brand1)
                .WithMany(t => t.ManagerBrands)
                .HasForeignKey(d => d.BrandID);

        }
    }
}
