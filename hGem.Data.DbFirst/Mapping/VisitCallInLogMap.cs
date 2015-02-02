using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitCallInLogMap : EntityTypeConfiguration<VisitCallInLog>
    {
        public VisitCallInLogMap()
        {
            // Primary Key
            HasKey(t => t.VisitCallInLogId);

            // Properties
            Property(t => t.VisitCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitCallInLog");
            Property(t => t.VisitCallInLogId).HasColumnName("VisitCallInLogID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.CallInLog)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.CallInLogId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
