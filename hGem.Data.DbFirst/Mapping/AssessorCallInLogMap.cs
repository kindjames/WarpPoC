using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorCallInLogMap : EntityTypeConfiguration<AssessorCallInLog>
    {
        public AssessorCallInLogMap()
        {
            // Primary Key
            HasKey(t => t.AssessorCallInLogId);

            // Properties
            Property(t => t.AssessorCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorCallInLog");
            Property(t => t.AssessorCallInLogId).HasColumnName("AssessorCallInLogID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            Property(t => t.Active).HasColumnName("Active");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.CallInLog)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.CallInLogId);

        }
    }
}
