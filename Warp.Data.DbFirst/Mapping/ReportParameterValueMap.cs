using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportParameterValueMap : EntityTypeConfiguration<ReportParameterValue>
    {
        public ReportParameterValueMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportParameterValueId);

            // Properties
            this.Property(t => t.ParameterName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReportParameterValue", "Reporting");
            this.Property(t => t.ReportParameterValueId).HasColumnName("ReportParameterValueId");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.ParameterName).HasColumnName("ParameterName");
            this.Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            this.Property(t => t.UseDefaultDynamicValue).HasColumnName("UseDefaultDynamicValue");
            this.Property(t => t.Hidden).HasColumnName("Hidden");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Report)
                .WithMany(t => t.ReportParameterValues)
                .HasForeignKey(d => d.ReportId);
            this.HasOptional(t => t.ReportParameterType)
                .WithMany(t => t.ReportParameterValues)
                .HasForeignKey(d => d.ReportParameterTypeId);

        }
    }
}
