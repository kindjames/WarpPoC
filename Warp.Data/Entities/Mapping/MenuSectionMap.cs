using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class MenuSectionMap : EntityTypeConfiguration<MenuSection>
    {
        public MenuSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuSectionID);

            // Properties
            this.Property(t => t.MenuSectionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MenuSection");
            this.Property(t => t.MenuSectionID).HasColumnName("MenuSectionID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
