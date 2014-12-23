using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionReportMap : EntityTypeConfiguration<SubscriptionReport>
    {
        public SubscriptionReportMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionReportId);

            // Properties
            // Table & Column Mappings
            ToTable("SubscriptionReport", "Subscriptions");
            Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Report)
                .WithMany(t => t.SubscriptionReports)
                .HasForeignKey(d => d.ReportId);
            HasRequired(t => t.Subscription)
                .WithMany(t => t.SubscriptionReports)
                .HasForeignKey(d => d.SubscriptionId);

        }
    }
}
