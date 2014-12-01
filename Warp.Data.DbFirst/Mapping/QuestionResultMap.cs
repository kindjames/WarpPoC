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
            this.HasKey(t => t.QuestionResultId);

            // Properties
            this.Property(t => t.QuestionResultId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("QuestionResult");
            this.Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            this.Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.QuestionnaireQuestionId).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerId).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.CheckedByAdminId).HasColumnName("CheckedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessment)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessmentId);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionId);

        }
    }
}
