using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AssessorCallBackRequestMap : EntityTypeConfiguration<AssessorCallBackRequest>
    {
        public AssessorCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorCallBackRequestId);

            // Properties
            this.Property(t => t.AssessorCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorCallBackRequest");
            this.Property(t => t.AssessorCallBackRequestId).HasColumnName("AssessorCallBackRequestID");
            this.Property(t => t.AssessorId).HasColumnName("AssessorID");
            this.Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.AssessorId);
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
