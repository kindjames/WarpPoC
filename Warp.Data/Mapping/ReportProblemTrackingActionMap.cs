using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportProblemTrackingActionMap : EntityTypeConfiguration<ReportProblemTrackingAction>
    {
        public ReportProblemTrackingActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemTrackingActionId);

            // Properties
            this.Property(t => t.ReportProblemTrackingActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReportProblemTrackingAction");
            this.Property(t => t.ReportProblemTrackingActionId).HasColumnName("ReportProblemTrackingActionID");
            this.Property(t => t.ReportProblemTrackingId).HasColumnName("ReportProblemTrackingID");
            this.Property(t => t.ReportProblemActionId).HasColumnName("ReportProblemActionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ReportProblemAction)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemActionId);
            this.HasRequired(t => t.ReportProblemTracking)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemTrackingId);

        }
    }
}
