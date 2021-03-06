using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportSectionMap : EntityTypeConfiguration<ReportSection>
    {
        public ReportSectionMap()
        {
            // Primary Key
            HasKey(t => t.ReportSectionId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ReportSection", "Reporting");
            Property(t => t.ReportSectionId).HasColumnName("ReportSectionId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
