using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionReportDestinationMap : EntityTypeConfiguration<SubscriptionReportDestination>
    {
        public SubscriptionReportDestinationMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionReportDestinationId);

            // Properties
            // Table & Column Mappings
            ToTable("SubscriptionReportDestination", "Subscriptions");
            Property(t => t.SubscriptionReportDestinationId).HasColumnName("SubscriptionReportDestinationId");
            Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            Property(t => t.DestinationId).HasColumnName("DestinationId");
            Property(t => t.ReportFormatId).HasColumnName("ReportFormatId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.Destination)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.DestinationId);
            HasOptional(t => t.ReportFormat)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.ReportFormatId);
            HasOptional(t => t.SubscriptionReport)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.SubscriptionReportId);

        }
    }
}
