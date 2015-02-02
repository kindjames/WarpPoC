using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ReportProblemActionMap : EntityTypeConfiguration<ReportProblemAction>
    {
        public ReportProblemActionMap()
        {
            // Primary Key
            HasKey(t => t.ReportProblemActionId);

            // Properties
            Property(t => t.ReportProblemActionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ReportProblemAction");
            Property(t => t.ReportProblemActionId).HasColumnName("ReportProblemActionID");
            Property(t => t.ReportProblemActionTypeId).HasColumnName("ReportProblemActionTypeID");
            Property(t => t.StartTime).HasColumnName("StartTime");
            Property(t => t.EndTime).HasColumnName("EndTime");
            Property(t => t.AddedByAdminId).HasColumnName("AddedByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.ReportProblemActionType)
                .WithMany(t => t.ReportProblemActions)
                .HasForeignKey(d => d.ReportProblemActionTypeId);

        }
    }
}
