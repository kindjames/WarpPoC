using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportProblemTypeMap : EntityTypeConfiguration<ReportProblemType>
    {
        public ReportProblemTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemTypeID);

            // Properties
            this.Property(t => t.ReportProblemTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("ReportProblemType");
            this.Property(t => t.ReportProblemTypeID).HasColumnName("ReportProblemTypeID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
