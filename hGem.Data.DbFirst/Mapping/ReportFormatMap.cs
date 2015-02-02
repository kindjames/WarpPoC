using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportFormatMap : EntityTypeConfiguration<ReportFormat>
    {
        public ReportFormatMap()
        {
            // Primary Key
            HasKey(t => t.ReportFormatId);

            // Properties
            Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            ToTable("ReportFormat", "Subscriptions");
            Property(t => t.ReportFormatId).HasColumnName("ReportFormatId");
            Property(t => t.Type).HasColumnName("Type");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
