using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AssessorCallBackRequestMap : EntityTypeConfiguration<AssessorCallBackRequest>
    {
        public AssessorCallBackRequestMap()
        {
            // Primary Key
            HasKey(t => t.AssessorCallBackRequestId);

            // Properties
            Property(t => t.AssessorCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AssessorCallBackRequest");
            Property(t => t.AssessorCallBackRequestId).HasColumnName("AssessorCallBackRequestID");
            Property(t => t.AssessorId).HasColumnName("AssessorID");
            Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.AssessorId);
            HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
