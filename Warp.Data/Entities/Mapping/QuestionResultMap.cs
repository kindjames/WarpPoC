using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class QuestionResultMap : EntityTypeConfiguration<QuestionResult>
    {
        public QuestionResultMap()
        {
            // Primary Key
            this.HasKey(t => t.QuestionResultID);

            // Properties
            this.Property(t => t.QuestionResultID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Comment)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("QuestionResult");
            this.Property(t => t.QuestionResultID).HasColumnName("QuestionResultID");
            this.Property(t => t.AssessmentID).HasColumnName("AssessmentID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.QuestionnaireQuestionID).HasColumnName("QuestionnaireQuestionID");
            this.Property(t => t.PossibleAnswerID).HasColumnName("PossibleAnswerID");
            this.Property(t => t.Comment).HasColumnName("Comment");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.CheckedByAdminID).HasColumnName("CheckedByAdminID");
            this.Property(t => t.DateValidFrom).HasColumnName("DateValidFrom");
            this.Property(t => t.DateValidTo).HasColumnName("DateValidTo");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessment)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessmentID);
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.QuestionnaireQuestion)
                .WithMany(t => t.QuestionResults)
                .HasForeignKey(d => d.QuestionnaireQuestionID);

        }
    }
}
