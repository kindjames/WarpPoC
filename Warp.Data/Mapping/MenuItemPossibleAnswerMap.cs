using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuItemPossibleAnswerMap : EntityTypeConfiguration<MenuItemPossibleAnswer>
    {
        public MenuItemPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuItemPossibleAnswerId);

            // Properties
            this.Property(t => t.MenuItemPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuItemPossibleAnswer");
            this.Property(t => t.MenuItemPossibleAnswerId).HasColumnName("MenuItemPossibleAnswerID");
            this.Property(t => t.MenuItemId).HasColumnName("MenuItemID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.MenuItemId);
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);

        }
    }
}
