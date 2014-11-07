using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuItemMap : EntityTypeConfiguration<MenuItem>
    {
        public MenuItemMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuItemID);

            // Properties
            this.Property(t => t.MenuItemID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.ImagePath)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("MenuItem");
            this.Property(t => t.MenuItemID).HasColumnName("MenuItemID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImagePath).HasColumnName("ImagePath");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
        }
    }
}
