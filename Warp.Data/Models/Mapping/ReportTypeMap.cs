using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportTypeMap : EntityTypeConfiguration<ReportType>
    {
        public ReportTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ReportType", "Reporting");
            this.Property(t => t.ReportTypeId).HasColumnName("ReportTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
