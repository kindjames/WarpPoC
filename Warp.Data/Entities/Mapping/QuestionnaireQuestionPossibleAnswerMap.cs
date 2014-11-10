using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class QuestionnaireQuestionPossibleAnswerMap : EntityTypeConfiguration<QuestionnaireQuestionPossibleAnswer>
    {
        public QuestionnaireQuestionPossibleAnswerMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionnaireQuestionPossibleAnswerID);

            // Properties
            this.Property(t => t.QuestionnaireQuestionPossibleAnswerID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Guidance)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("QuestionnaireQuestionPossibleAnswer");
            this.Property(t => t.QuestionnaireQuestionPossibleAnswerID).HasColumnName("QuestionnaireQuestionPossibleAnswerID");
            this.Property(t => t.QuestionnaireQuestionID).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.Guidance).HasColumnName("Guidance");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.QuestionnaireQuestionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerID);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.QuestionnaireQuestionPossibleAnswers)
                .HasForeignKey(d => d.QuestionnaireQuestionID);

        }
    }
}
