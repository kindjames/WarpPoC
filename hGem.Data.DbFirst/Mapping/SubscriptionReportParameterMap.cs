using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class SubscriptionReportParameterMap : EntityTypeConfiguration<SubscriptionReportParameter>
    {
        public SubscriptionReportParameterMap()
        {
            // Primary Key
            HasKey(t => t.SubscriptionReportParameterId);

            // Properties
            Property(t => t.ParameterName)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            ToTable("SubscriptionReportParameter", "Subscriptions");
            Property(t => t.SubscriptionReportParameterId).HasColumnName("SubscriptionReportParameterId");
            Property(t => t.SubscriptionReportId).HasColumnName("SubscriptionReportId");
            Property(t => t.ParameterName).HasColumnName("ParameterName");
            Property(t => t.Value).HasColumnName("Value");
            Property(t => t.Loop).HasColumnName("Loop");
            Property(t => t.UseAll).HasColumnName("UseAll");
            Property(t => t.UseDynamicValue).HasColumnName("UseDynamicValue");
            Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasOptional(t => t.ReportParameterType)
                .WithMany(t => t.SubscriptionReportParameters)
                .HasForeignKey(d => d.ReportParameterTypeId);
            HasRequired(t => t.SubscriptionReport)
                .WithMany(t => t.SubscriptionReportParameters)
                .HasForeignKey(d => d.SubscriptionReportId);

        }
    }
}
