using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportSourceMap : EntityTypeConfiguration<ReportSource>
    {
        public ReportSourceMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportSourceId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.SSRSPath)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ReportSource", "Reporting");
            this.Property(t => t.ReportSourceId).HasColumnName("ReportSourceId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.SSRSPath).HasColumnName("SSRSPath");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
