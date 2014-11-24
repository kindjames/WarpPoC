using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportMap : EntityTypeConfiguration<Report>
    {
        public ReportMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.SSRSName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Purpose)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.PreviewImagePath)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("Report", "Reporting");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ReportCategoryId).HasColumnName("ReportCategoryId");
            this.Property(t => t.SSRSName).HasColumnName("SSRSName");
            this.Property(t => t.ReportSourceId).HasColumnName("ReportSourceId");
            this.Property(t => t.DateLastChecked).HasColumnName("DateLastChecked");
            this.Property(t => t.DefaultReportSectionId).HasColumnName("DefaultReportSectionId");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.HideDescription).HasColumnName("HideDescription");
            this.Property(t => t.Purpose).HasColumnName("Purpose");
            this.Property(t => t.HidePurpose).HasColumnName("HidePurpose");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.PreviewImagePath).HasColumnName("PreviewImagePath");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.CreatedByUserRoleId).HasColumnName("CreatedByUserRoleId");
            this.Property(t => t.DateRemoved).HasColumnName("DateRemoved");
            this.Property(t => t.RemovedbyUserRoleId).HasColumnName("RemovedbyUserRoleId");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.UserRole)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.CreatedByUserRoleId);
            this.HasOptional(t => t.UserRole1)
                .WithMany(t => t.Reports1)
                .HasForeignKey(d => d.RemovedbyUserRoleId);
            this.HasRequired(t => t.ReportCategory)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.ReportCategoryId);
            this.HasRequired(t => t.ReportSection)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.DefaultReportSectionId);
            this.HasRequired(t => t.ReportSource)
                .WithMany(t => t.Reports)
                .HasForeignKey(d => d.ReportSourceId);

        }
    }
}
