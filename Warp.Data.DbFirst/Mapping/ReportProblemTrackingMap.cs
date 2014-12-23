using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportProblemTrackingMap : EntityTypeConfiguration<ReportProblemTracking>
    {
        public ReportProblemTrackingMap()
        {
            // Primary Key
            HasKey(t => t.ReportProblemTrackingId);

            // Properties
            Property(t => t.ReportProblemTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("ReportProblemTracking");
            Property(t => t.ReportProblemTrackingId).HasColumnName("ReportProblemTrackingID");
            Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            Property(t => t.ReportProblemCauseId).HasColumnName("ReportProblemCauseID");
            Property(t => t.ReportProblemTypeId).HasColumnName("ReportProblemTypeID");
            Property(t => t.DetectedByAdminId).HasColumnName("DetectedByAdminID");
            Property(t => t.Resolved).HasColumnName("Resolved");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.CreatedQuestionResultId).HasColumnName("CreatedQuestionResultID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.QuestionResult)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.QuestionResultId);
            HasOptional(t => t.QuestionResult1)
                .WithMany(t => t.ReportProblemTrackings1)
                .HasForeignKey(d => d.CreatedQuestionResultId);
            HasRequired(t => t.ReportProblemCause)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemCauseId);
            HasRequired(t => t.ReportProblemType)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemTypeId);

        }
    }
}
