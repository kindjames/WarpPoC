using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class MenuSectionPossibleAnswerMap : EntityTypeConfiguration<MenuSectionPossibleAnswer>
    {
        public MenuSectionPossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.MenuSectionPossibleAnswerId);

            // Properties
            Property(t => t.MenuSectionPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("MenuSectionPossibleAnswer");
            Property(t => t.MenuSectionPossibleAnswerId).HasColumnName("MenuSectionPossibleAnswerID");
            Property(t => t.MenuSectionId).HasColumnName("MenuSectionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.MenuSectionId);
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);

        }
    }
}
