using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessmentMap : EntityTypeConfiguration<Assessment>
    {
        public AssessmentMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentId);

            // Properties
            this.Property(t => t.AssessmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Assessment");
            this.Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            this.Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            this.Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.BriefId).HasColumnName("BriefID");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.LastUpdatedAdminId).HasColumnName("LastUpdatedAdminID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            this.Property(t => t.Invoiced).HasColumnName("Invoiced");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.AssessmentAreaId);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.BriefId);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.QuestionnaireId);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.SubQuestionnaireId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
