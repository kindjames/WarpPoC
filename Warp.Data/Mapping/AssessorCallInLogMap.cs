using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorCallInLogMap : EntityTypeConfiguration<AssessorCallInLog>
    {
        public AssessorCallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorCallInLogId);

            // Properties
            this.Property(t => t.AssessorCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorCallInLog");
            this.Property(t => t.AssessorCallInLogId).HasColumnName("AssessorCallInLogID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.CallInLogId);

        }
    }
}
