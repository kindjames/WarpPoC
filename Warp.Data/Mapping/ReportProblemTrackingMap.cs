using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportProblemTrackingMap : EntityTypeConfiguration<ReportProblemTracking>
    {
        public ReportProblemTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemTrackingId);

            // Properties
            this.Property(t => t.ReportProblemTrackingId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ReportProblemTracking");
            this.Property(t => t.ReportProblemTrackingId).HasColumnName("ReportProblemTrackingID");
            this.Property(t => t.QuestionResultId).HasColumnName("QuestionResultID");
            this.Property(t => t.ReportProblemCauseId).HasColumnName("ReportProblemCauseID");
            this.Property(t => t.ReportProblemTypeId).HasColumnName("ReportProblemTypeID");
            this.Property(t => t.DetectedByAdminId).HasColumnName("DetectedByAdminID");
            this.Property(t => t.Resolved).HasColumnName("Resolved");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.CreatedQuestionResultId).HasColumnName("CreatedQuestionResultID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.QuestionResult)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.QuestionResultId);
            this.HasOptional(t => t.QuestionResult1)
                .WithMany(t => t.ReportProblemTrackings1)
                .HasForeignKey(d => d.CreatedQuestionResultId);
            this.HasRequired(t => t.ReportProblemCause)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemCauseId);
            this.HasRequired(t => t.ReportProblemType)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemTypeId);

        }
    }
}
