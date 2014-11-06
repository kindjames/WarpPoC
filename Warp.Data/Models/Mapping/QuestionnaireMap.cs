using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class QuestionnaireMap : EntityTypeConfiguration<Questionnaire>
    {
        public QuestionnaireMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireID);

            // Properties
            this.Property(t => t.QuestionnaireID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Questionnaire");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.QuestionnaireStatusID).HasColumnName("QuestionnaireStatusID");
            this.Property(t => t.QuestionnaireTypeID).HasColumnName("QuestionnaireTypeID");
            this.Property(t => t.VisitTypeID).HasColumnName("VisitTypeID");

            // Relationships
            this.HasRequired(t => t.QuestionnaireStatu)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.QuestionnaireStatusID);
            this.HasRequired(t => t.VisitType)
                .WithMany(t => t.Questionnaires)
                .HasForeignKey(d => d.VisitTypeID);

        }
    }
}
