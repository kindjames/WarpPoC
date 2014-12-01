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
            this.HasKey(t => t.VisitCallInLogId);

            // Properties
            this.Property(t => t.VisitCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitCallInLog");
            this.Property(t => t.VisitCallInLogId).HasColumnName("VisitCallInLogID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.CallInLogId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallInLogs)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
