using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuConfigMap : EntityTypeConfiguration<MenuConfig>
    {
        public MenuConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigId);

            // Properties
            this.Property(t => t.MenuConfigId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfig");
            this.Property(t => t.MenuConfigId).HasColumnName("MenuConfigID");
            this.Property(t => t.MenuId).HasColumnName("MenuID");
            this.Property(t => t.MenuSectionId).HasColumnName("MenuSectionID");
            this.Property(t => t.MenuItemId).HasColumnName("MenuItemID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Menu)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuId);
            this.HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuItemId);
            this.HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuSectionId);

        }
    }
}
