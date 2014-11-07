using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportFormatMap : EntityTypeConfiguration<ReportFormat>
    {
        public ReportFormatMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportFormatId);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("ReportFormat", "Subscriptions");
            this.Property(t => t.ReportFormatId).HasColumnName("ReportFormatId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
