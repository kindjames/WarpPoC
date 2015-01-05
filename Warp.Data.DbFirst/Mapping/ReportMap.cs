using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportMap : EntityTypeConfiguration<Report>
    {
        public ReportMap()
        {
            // Primary Key
            HasKey(t => t.ReportId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            Property(t => t.SSRSName)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Purpose)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            Property(t => t.PreviewImagePath)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("Report", "Reporting");
            Property(t => t.ReportId).HasColumnName("ReportId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.ReportCategoryId).HasColumnName("ReportCategoryId");
            Property(t => t.SSRSName).HasColumnName("SSRSName");
            Property(t => t.ReportSourceId).HasColumnName("ReportSourceId");
            Property(t => t.DateLastChecked).HasColumnName("DateLastChecked");
            Property(t => t.DefaultReportSectionId).HasColumnName("DefaultReportSectionId");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.HideDescription).HasColumnName("HideDescription");
            Property(t => t.Purpose).HasColumnName("Purpose");
            Property(t => t.HidePurpose).HasColumnName("HidePurpose");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.PreviewImagePath).HasColumnName("PreviewImagePath");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            Property(t => t.RemovedbyUserRoleId).HasColumnName("RemovedbyUserRoleId");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.UserRole)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            HasRequired(t => t.ReportCategory)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.ReportCategoryId);
            HasRequired(t => t.ReportSection)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.DefaultReportSectionId);
            HasRequired(t => t.ReportSource)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.ReportSourceId);

        }
    }
}
