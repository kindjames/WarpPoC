using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ReportProblemActionMap : EntityTypeConfiguration<ReportProblemAction>
    {
        public ReportProblemActionMap()
        {
            // Primary Key
            this.HasKey(t => t.ReportProblemActionId);

            // Properties
            this.Property(t => t.ReportProblemActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ReportProblemAction");
            this.Property(t => t.ReportProblemActionId).HasColumnName("ReportProblemActionID");
            this.Property(t => t.ReportProblemActionTypeId).HasColumnName("ReportProblemActionTypeID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ReportProblemActionType)
                .WithMany(t => t.ReportProblemActions)
                .HasForeignKey(d => d.ReportProblemActionTypeId);

        }
    }
}
