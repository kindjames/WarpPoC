using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportProblemTrackingActionMap : EntityTypeConfiguration<ReportProblemTrackingAction>
    {
        public ReportProblemTrackingActionMap()
        {
            // Primary Key
            HasKey(t => t.ReportProblemTrackingActionId);

            // Properties
            Property(t => t.ReportProblemTrackingActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ReportProblemTrackingAction");
            Property(t => t.ReportProblemTrackingActionId).HasColumnName("ReportProblemTrackingActionID");
            Property(t => t.ReportProblemTrackingId).HasColumnName("ReportProblemTrackingID");
            Property(t => t.ReportProblemActionId).HasColumnName("ReportProblemActionID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ReportProblemAction)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemActionId);
            HasRequired(t => t.ReportProblemTracking)
                .WithMany(t => t.ReportProblemTrackingActions)
                .HasForeignKey(d => d.ReportProblemTrackingId);

        }
    }
}
