using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportParameterValueMap : EntityTypeConfiguration<ReportParameterValue>
    {
        public ReportParameterValueMap()
        {
            // Primary Key
            HasKey(t => t.ReportParameterValueId);

            // Properties
            Property(t => t.ParameterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ReportParameterValue", "Reporting");
            Property(t => t.ReportParameterValueId).HasColumnName("ReportParameterValueId");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.ParameterName).HasColumnName("ParameterName");
            Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            Property(t => t.UseDefaultDynamicValue).HasColumnName("UseDefaultDynamicValue");
            Property(t => t.Hidden).HasColumnName("Hidden");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Report)
                .WithMany(t => t.ReportParameterValues)
                .HasForeignKey(d => d.ReportId);
            HasOptional(t => t.ReportParameterType)
                .WithMany(t => t.ReportParameterValues)
                .HasForeignKey(d => d.ReportParameterTypeId);

        }
    }
}
