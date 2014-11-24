using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportParameterTypeMap : EntityTypeConfiguration<ReportParameterType>
    {
        public ReportParameterTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportParameterTypeId);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("ReportParameterType", "Reporting");
            this.Property(t => t.ReportParameterTypeId).HasColumnName("ReportParameterTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.HideByDefault).HasColumnName("HideByDefault");
            this.Property(t => t.UseDefaultValueByDefault).HasColumnName("UseDefaultValueByDefault");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
