using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuSectionMap : EntityTypeConfiguration<MenuSection>
    {
        public MenuSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuSectionId);

            // Properties
            this.Property(t => t.MenuSectionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MenuSection");
            this.Property(t => t.MenuSectionId).HasColumnName("MenuSectionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
