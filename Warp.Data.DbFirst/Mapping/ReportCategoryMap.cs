using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportCategoryMap : EntityTypeConfiguration<ReportCategory>
    {
        public ReportCategoryMap()
        {
            // Primary Key
            HasKey(t => t.ReportCategoryId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("ReportCategory", "Reporting");
            Property(t => t.ReportCategoryId).HasColumnName("ReportCategoryId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
