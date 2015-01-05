using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuItemPossibleAnswerMap : EntityTypeConfiguration<MenuItemPossibleAnswer>
    {
        public MenuItemPossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.MenuItemPossibleAnswerId);

            // Properties
            Property(t => t.MenuItemPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuItemPossibleAnswer");
            Property(t => t.MenuItemPossibleAnswerId).HasColumnName("MenuItemPossibleAnswerID");
            Property(t => t.MenuItemId).HasColumnName("MenuItemID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.MenuItem)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.MenuItemId);
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuItemPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);

        }
    }
}
