using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class AssessorCallInLogMap : EntityTypeConfiguration<AssessorCallInLog>
    {
        public AssessorCallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorCallInLogID);

            // Properties
            this.Property(t => t.AssessorCallInLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorCallInLog");
            this.Property(t => t.AssessorCallInLogID).HasColumnName("AssessorCallInLogID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.CallInLogID).HasColumnName("CallInLogID");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.AssessorCallInLogs)
                .HasForeignKey(d => d.CallInLogID);

        }
    }
}
