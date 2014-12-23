using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportTypeMap : EntityTypeConfiguration<ReportType>
    {
        public ReportTypeMap()
        {
            // Primary Key
            HasKey(t => t.ReportTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ReportType", "Reporting");
            Property(t => t.ReportTypeId).HasColumnName("ReportTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
