using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportSectionMap : EntityTypeConfiguration<ReportSection>
    {
        public ReportSectionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportSectionId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReportSection", "Reporting");
            this.Property(t => t.ReportSectionId).HasColumnName("ReportSectionId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
