using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class TriggerInstanceReportMap : EntityTypeConfiguration<TriggerInstanceReport>
    {
        public TriggerInstanceReportMap()
        {
            // Primary Key
            this.HasKey(t => t.TriggerInstanceReportId);

            // Properties
            // Table & Column Mappings
            this.ToTable("TriggerInstanceReport", "Subscriptions");
            this.Property(t => t.TriggerInstanceReportId).HasColumnName("TriggerInstanceReportId");
            this.Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            this.Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            this.Property(t => t.TriggerInstanceReportStatusTypeId).HasColumnName("TriggerInstanceReportStatusTypeId");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            this.HasRequired(t => t.SubscriptionReport)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.SubscriptionReportId);
            this.HasRequired(t => t.TriggerInstance)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.TriggerInstanceId);
            this.HasRequired(t => t.TriggerInstanceReportStatusType)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.TriggerInstanceReportStatusTypeId);

        }
    }
}
