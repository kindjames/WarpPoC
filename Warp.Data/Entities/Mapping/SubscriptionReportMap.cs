using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class SubscriptionReportMap : EntityTypeConfiguration<SubscriptionReport>
    {
        public SubscriptionReportMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionReportId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubscriptionReport", "Subscriptions");
            this.Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            this.Property(t => t.SubscriptionId).HasColumnName("SubscriptionId");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Report)
                .WithMany(t => t.SubscriptionReports)
                .HasForeignKey(d => d.ReportId);
            this.HasRequired(t => t.Subscription)
                .WithMany(t => t.SubscriptionReports)
                .HasForeignKey(d => d.SubscriptionId);

        }
    }
}
