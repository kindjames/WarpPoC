using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class MenuItemPossibleAnswerMap : EntityTypeConfiguration<MenuItemPossibleAnswer>
    {
        public MenuItemPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuItemPossibleAnswerID);

            // Properties
            this.Property(t => t.MenuItemPossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuItemPossibleAnswer");
            this.Property(t => t.MenuItemPossibleAnswerID).HasColumnName("MenuItemPossibleAnswerID");
            this.Property(t => t.MenuItemID).HasColumnName("MenuItemID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.MenuItemID);
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerID);

        }
    }
}
