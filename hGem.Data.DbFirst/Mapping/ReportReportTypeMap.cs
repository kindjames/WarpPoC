using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportReportTypeMap : EntityTypeConfiguration<ReportReportType>
    {
        public ReportReportTypeMap()
        {
            // Primary Key
            HasKey(t => t.ReportReportTypeId);

            // Properties
            // Table & Column Mappings
            ToTable("ReportReportType", "Reporting");
            Property(t => t.ReportReportTypeId).HasColumnName("ReportReportTypeId");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.ReportTypeId).HasColumnName("ReportTypeId");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            Property(t => t.RemovedByUserRoleId).HasColumnName("RemovedByUserRoleId");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            HasRequired(t => t.Report)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.ReportId);
            HasRequired(t => t.ReportType)
                .WithMany(t => t.ReportReportTypes)
                .HasForeignKey(d => d.ReportTypeId);

        }
    }
}
