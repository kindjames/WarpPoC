using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuConfigBrandMap : EntityTypeConfiguration<MenuConfigBrand>
    {
        public MenuConfigBrandMap()
        {
            // Primary Key
            HasKey(t => t.MenuConfigBrandId);

            // Properties
            Property(t => t.MenuConfigBrandId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuConfigBrand");
            Property(t => t.MenuConfigBrandId).HasColumnName("MenuConfigBrandID");
            Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            Property(t => t.BrandId).HasColumnName("BrandID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.Permission).HasColumnName("Permission");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Brand)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.BrandId);
            HasRequired(t => t.MenuConfig)
                .WithMany(t => t.MenuConfigBrands)
                .HasForeignKey(d => d.MenuConfigId);

        }
    }
}
