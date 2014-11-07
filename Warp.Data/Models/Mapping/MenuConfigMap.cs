using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuConfigMap : EntityTypeConfiguration<MenuConfig>
    {
        public MenuConfigMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuConfigID);

            // Properties
            this.Property(t => t.MenuConfigID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuConfig");
            this.Property(t => t.MenuConfigID).HasColumnName("MenuConfigID");
            this.Property(t => t.MenuID).HasColumnName("MenuID");
            this.Property(t => t.MenuSectionID).HasColumnName("MenuSectionID");
            this.Property(t => t.MenuItemID).HasColumnName("MenuItemID");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Menu)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuID);
            this.HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuItemID);
            this.HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuConfigs)
                .HasForeignKey(d => d.MenuSectionID);

        }
    }
}
