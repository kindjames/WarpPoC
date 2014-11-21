using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportReportTypeMap : EntityTypeConfiguration<ReportReportType>
    {
        public ReportReportTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportReportTypeId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ReportReportType", "Reporting");
            this.Property(t => t.ReportReportTypeId).HasColumnName("ReportReportTypeId");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.ReportTypeId).HasColumnName("ReportTypeId");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedByUserRoleId).HasColumnName("RemovedByUserRoleId");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            this.HasOptional(t => t.UserRole1)
                .WithMany(t => t.ReportReportTypes1)
                .HasForeignKey(d => d.RemovedByUserRoleId);
            this.HasRequired(t => t.Report)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.ReportId);
            this.HasRequired(t => t.ReportType)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.ReportTypeId);

        }
    }
}
