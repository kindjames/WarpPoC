using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class QuestionResultMap : EntityTypeConfiguration<QuestionResult>
    {
        public QuestionResultMap()
        {
            // Primary Key
            HasKey(t => t.QuestionResultId);

            // Properties
            Property(t => t.QuestionResultId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Comment)
                .HasMaxLength(300);

            // Table & Column Mappings
            ToTable("QuestionResult");
            Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            Property(t => t.Comment).HasColumnName("Comment");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessment)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessmentId);
            HasRequired(t => t.Assessor)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionId);

        }
    }
}
