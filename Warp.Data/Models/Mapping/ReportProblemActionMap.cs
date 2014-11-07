using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ReportProblemActionMap : EntityTypeConfiguration<ReportProblemAction>
    {
        public ReportProblemActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemActionID);

            // Properties
            this.Property(t => t.ReportProblemActionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReportProblemAction");
            this.Property(t => t.ReportProblemActionID).HasColumnName("ReportProblemActionID");
            this.Property(t => t.ReportProblemActionTypeID).HasColumnName("ReportProblemActionTypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.AddedByAdminID).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ReportProblemActionType)
                .WithMany(t => t.ReportProblemActions)
                .HasForeignKey(d => d.ReportProblemActionTypeID);

        }
    }
}
