using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class TriggerInstanceReportMap : EntityTypeConfiguration<TriggerInstanceReport>
    {
        public TriggerInstanceReportMap()
        {
            // Primary Key
            HasKey(t => t.TriggerInstanceReportId);

            // Properties
            // Table & Column Mappings
            ToTable("TriggerInstanceReport", "Subscriptions");
            Property(t => t.TriggerInstanceReportId).HasColumnName("TriggerInstanceReportId");
            Property(t => t.TriggerInstanceId).HasColumnName("TriggerInstanceId");
            Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            Property(t => t.TriggerInstanceReportStatusTypeId).HasColumnName("TriggerInstanceReportStatusTypeId");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");

            // Relationships
            HasRequired(t => t.SubscriptionReport)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.SubscriptionReportId);
            HasRequired(t => t.TriggerInstance)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.TriggerInstanceId);
            HasRequired(t => t.TriggerInstanceReportStatusType)
                .WithMany(t => t.TriggerInstanceReports)
                .HasForeignKey(d => d.TriggerInstanceReportStatusTypeId);

        }
    }
}
