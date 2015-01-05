using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessmentMap : EntityTypeConfiguration<Assessment>
    {
        public AssessmentMap()
        {
            // Primary Key
            HasKey(t => t.AssessmentId);

            // Properties
            Property(t => t.AssessmentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("Assessment");
            Property(t => t.AssessmentId).HasColumnName("AssessmentID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            Property(t => t.QuestionnaireId).HasColumnName("QuestionnaireID");
            Property(t => t.SubQuestionnaireId).HasColumnName("SubQuestionnaireID");
            Property(t => t.BriefId).HasColumnName("BriefID");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateAdded).HasColumnName("DateAdded");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.LastUpdatedAdminId).HasColumnName("LastUpdatedAdminID");
            Property(t => t.Score).HasColumnName("Score");
            Property(t => t.MaxScore).HasColumnName("MaxScore");
            Property(t => t.DateScoreCalculated).HasColumnName("DateScoreCalculated");
            Property(t => t.Invoiced).HasColumnName("Invoiced");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.AssessmentAreaId);
            HasRequired(t => t.Brief)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.BriefId);
            HasRequired(t => t.Questionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.QuestionnaireId);
            HasRequired(t => t.SubQuestionnaire)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.SubQuestionnaireId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.Assessments)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
