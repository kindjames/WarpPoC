using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportSourceMap : EntityTypeConfiguration<ReportSource>
    {
        public ReportSourceMap()
        {
            // Primary Key
            HasKey(t => t.ReportSourceId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.SSRSPath)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            ToTable("ReportSource", "Reporting");
            Property(t => t.ReportSourceId).HasColumnName("ReportSourceId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.SSRSPath).HasColumnName("SSRSPath");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
