using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessmentMap : EntityTypeConfiguration<Assessment>
    {
        public AssessmentMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessmentID);

            // Properties
            this.Property(t => t.AssessmentID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Assessment");
            this.Property(t => t.AssessmentID).HasColumnName("AssessmentID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.AssessmentAreaID).HasColumnName("AssessmentAreaID");
            this.Property(t => t.QuestionnaireID).HasColumnName("QuestionnaireID");
            this.Property(t => t.SubQuestionnaireID).HasColumnName("SubQuestionnaireID");
            this.Property(t => t.BriefID).HasColumnName("BriefID");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateAdded).HasColumnName("DateAdded");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.LastUpdatedAdminID).HasColumnName("LastUpdatedAdminID");
            this.Property(t => t.Score).HasColumnName("Score");
            this.Property(t => t.MaxScore).HasColumnName("MaxScore");
            this.Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            this.Property(t => t.Invoiced).HasColumnName("Invoiced");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.AssessmentAreaID);
            this.HasRequired(t => t.Brief)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.BriefID);
            this.HasRequired(t => t.Questionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.QuestionnaireID);
            this.HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.SubQuestionnaireID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
