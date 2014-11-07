using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuConfigBrandMap : EntityTypeConfiguration<MenuConfigBrand>
    {
        public MenuConfigBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigBrandID);

            // Properties
            this.Property(t => t.MenuConfigBrandID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigBrand");
            this.Property(t => t.MenuConfigBrandID).HasColumnName("MenuConfigBrandID");
            this.Property(t => t.MenuConfigID).HasColumnName("MenuConfigID");
            this.Property(t => t.BrandID).HasColumnName("BrandID");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.BrandID);
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.MenuConfigID);

        }
    }
}
