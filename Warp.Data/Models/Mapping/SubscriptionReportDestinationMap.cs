using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class SubscriptionReportDestinationMap : EntityTypeConfiguration<SubscriptionReportDestination>
    {
        public SubscriptionReportDestinationMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionReportDestinationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("SubscriptionReportDestination", "Subscriptions");
            this.Property(t => t.SubscriptionReportDestinationId).HasColumnName("SubscriptionReportDestinationId");
            this.Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            this.Property(t => t.DestinationId).HasColumnName("DestinationId");
            this.Property(t => t.ReportFormatId).HasColumnName("ReportFormatId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.Destination)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.DestinationId);
            this.HasOptional(t => t.ReportFormat)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.ReportFormatId);
            this.HasOptional(t => t.SubscriptionReport)
                .WithMany(t => t.SubscriptionReportDestinations)
                .HasForeignKey(d => d.SubscriptionReportId);

        }
    }
}
