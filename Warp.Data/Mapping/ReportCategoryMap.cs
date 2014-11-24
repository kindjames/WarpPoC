using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportCategoryMap : EntityTypeConfiguration<ReportCategory>
    {
        public ReportCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportCategoryId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReportCategory", "Reporting");
            this.Property(t => t.ReportCategoryId).HasColumnName("ReportCategoryId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
