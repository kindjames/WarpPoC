using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportProblemTrackingMap : EntityTypeConfiguration<ReportProblemTracking>
    {
        public ReportProblemTrackingMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemTrackingID);

            // Properties
            this.Property(t => t.ReportProblemTrackingID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("ReportProblemTracking");
            this.Property(t => t.ReportProblemTrackingID).HasColumnName("ReportProblemTrackingID");
            this.Property(t => t.QuestionResultID).HasColumnName("QuestionResultID");
            this.Property(t => t.ReportProblemCauseID).HasColumnName("ReportProblemCauseID");
            this.Property(t => t.ReportProblemTypeID).HasColumnName("ReportProblemTypeID");
            this.Property(t => t.DetectedByAdminID).HasColumnName("DetectedByAdminID");
            this.Property(t => t.Resolved).HasColumnName("Resolved");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.CreatedQuestionResultID).HasColumnName("CreatedQuestionResultID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.QuestionResult)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.QuestionResultID);
            this.HasOptional(t => t.QuestionResult1)
                .WithMany(t => t.ReportProblemTrackings1)
                .HasForeignKey(d => d.CreatedQuestionResultID);
            this.HasRequired(t => t.ReportProblemCause)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemCauseID);
            this.HasRequired(t => t.ReportProblemType)
                .WithMany(t => t.ReportProblemTrackings)
                .HasForeignKey(d => d.ReportProblemTypeID);

        }
    }
}
