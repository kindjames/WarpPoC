using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class SubscriptionReportParameterMap : EntityTypeConfiguration<SubscriptionReportParameter>
    {
        public SubscriptionReportParameterMap()
        {
            // Primary Key
            this.HasKey(t => t.SubscriptionReportParameterId);

            // Properties
            this.Property(t => t.ParameterName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("SubscriptionReportParameter", "Subscriptions");
            this.Property(t => t.SubscriptionReportParameterId).HasColumnName("SubscriptionReportParameterId");
            this.Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            this.Property(t => t.ParameterName).HasColumnName("ParameterName");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.Loop).HasColumnName("Loop");
            this.Property(t => t.UseAll).HasColumnName("UseAll");
            this.Property(t => t.UseDynamicValue).HasColumnName("UseDynamicValue");
            this.Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasOptional(t => t.ReportParameterType)
                .WithMany(t => t.SubscriptionReportParameters)
                .HasForeignKey(d => d.ReportParameterTypeId);
            this.HasRequired(t => t.SubscriptionReport)
                .WithMany(t => t.SubscriptionReportParameters)
                .HasForeignKey(d => d.SubscriptionReportId);

        }
    }
}
