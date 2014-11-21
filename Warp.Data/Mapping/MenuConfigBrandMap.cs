using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuConfigBrandMap : EntityTypeConfiguration<MenuConfigBrand>
    {
        public MenuConfigBrandMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigBrandId);

            // Properties
            this.Property(t => t.MenuConfigBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfigBrand");
            this.Property(t => t.MenuConfigBrandId).HasColumnName("MenuConfigBrandID");
            this.Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            this.Property(t => t.BrandId).HasColumnName("BrandID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.Permission).HasColumnName("Permission");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Brand)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.BrandId);
            this.HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
