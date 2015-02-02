using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuConfigMap : EntityTypeConfiguration<MenuConfig>
    {
        public MenuConfigMap()
        {
            // Primary Key
            HasKey(t => t.MenuConfigId);

            // Properties
            Property(t => t.MenuConfigId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuConfig");
            Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            Property(t => t.MenuId).HasColumnName("MenuID");
            Property(t => t.MenuSectionId).HasColumnName("MenuSectionID");
            Property(t => t.MenuItemId).HasColumnName("MenuItemID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Menu)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuId);
            HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuItemId);
            HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuSectionId);

        }
    }
}
