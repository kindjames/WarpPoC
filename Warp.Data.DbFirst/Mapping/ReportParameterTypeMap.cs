using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportParameterTypeMap : EntityTypeConfiguration<ReportParameterType>
    {
        public ReportParameterTypeMap()
        {
            // Primary Key
            HasKey(t => t.ReportParameterTypeId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            ToTable("ReportParameterType", "Reporting");
            Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Code).HasColumnName("Code");
            Property(t => t.HideByDefault).HasColumnName("HideByDefault");
            Property(t => t.UseDefaultValueByDefault).HasColumnName("UseDefaultValueByDefault");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
