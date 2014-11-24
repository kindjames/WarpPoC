using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class MenuSectionPossibleAnswerMap : EntityTypeConfiguration<MenuSectionPossibleAnswer>
    {
        public MenuSectionPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.MenuSectionPossibleAnswerId);

            // Properties
            this.Property(t => t.MenuSectionPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("MenuSectionPossibleAnswer");
            this.Property(t => t.MenuSectionPossibleAnswerId).HasColumnName("MenuSectionPossibleAnswerID");
            this.Property(t => t.MenuSectionId).HasColumnName("MenuSectionID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.MenuSection)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.MenuSectionId);
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.MenuSectionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);

        }
    }
}
