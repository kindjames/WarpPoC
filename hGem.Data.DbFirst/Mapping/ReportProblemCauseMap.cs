using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportProblemCauseMap : EntityTypeConfiguration<ReportProblemCause>
    {
        public ReportProblemCauseMap()
        {
            // Primary Key
            HasKey(t => t.ReportProblemCauseId);

            // Properties
            Property(t => t.ReportProblemCauseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.Description)
                .HasMaxLength(200);

            // Table & Column Mappings
            ToTable("ReportProblemCause");
            Property(t => t.ReportProblemCauseId).HasColumnName("ReportProblemCauseID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.Description).HasColumnName("Description");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
