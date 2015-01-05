using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionnaireQuestionPossibleAnswerMap : EntityTypeConfiguration<QuestionnaireQuestionPossibleAnswer>
    {
        public QuestionnaireQuestionPossibleAnswerMap()
        {
            // Primary Key
            HasKey(t => t.QuestionnaireQuestionPossibleAnswerId);

            // Properties
            Property(t => t.QuestionnaireQuestionPossibleAnswerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Guidance)
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("QuestionnaireQuestionPossibleAnswer");
            Property(t => t.QuestionnaireQuestionPossibleAnswerId).HasColumnName("QuestionnaireQuestionPossibleAnswerID");
            Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.Guidance).HasColumnName("Guidance");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.PossibleAnswer)
                .WithMany(t => t.QuestionnaireQuestionPossibleAnswers)
                .HasForeignKey(d => d.PossibleAnswerId);
            HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.QuestionnaireQuestionPossibleAnswers)
                .HasForeignKey(d => d.QuestionnaireQuestionId);

        }
    }
}
