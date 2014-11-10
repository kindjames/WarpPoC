using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class MenuSectionPossibleAnswerMap : EntityTypeConfiguration<MenuSectionPossibleAnswer>
    {
        public MenuSectionPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuSectionPossibleAnswerID);

            // Properties
            this.Property(t => t.MenuSectionPossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuSectionPossibleAnswer");
            this.Property(t => t.MenuSectionPossibleAnswerID).HasColumnName("MenuSectionPossibleAnswerID");
            this.Property(t => t.MenuSectionID).HasColumnName("MenuSectionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.MenuSectionID);
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerID);

        }
    }
}
