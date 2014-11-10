using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class ReportProblemTrackingActionMap : EntityTypeConfiguration<ReportProblemTrackingAction>
    {
        public ReportProblemTrackingActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemTrackingActionID);

            // Properties
            this.Property(t => t.ReportProblemTrackingActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReportProblemTrackingAction");
            this.Property(t => t.ReportProblemTrackingActionID).HasColumnName("ReportProblemTrackingActionID");
            this.Property(t => t.ReportProblemTrackingID).HasColumnName("ReportProblemTrackingID");
            this.Property(t => t.ReportProblemActionID).HasColumnName("ReportProblemActionID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ReportProblemAction)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemActionID);
            this.HasRequired(t => t.ReportProblemTracking)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemTrackingID);

        }
    }
}
