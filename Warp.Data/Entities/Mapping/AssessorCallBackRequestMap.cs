using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AssessorCallBackRequestMap : EntityTypeConfiguration<AssessorCallBackRequest>
    {
        public AssessorCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.AssessorCallBackRequestID);

            // Properties
            this.Property(t => t.AssessorCallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AssessorCallBackRequest");
            this.Property(t => t.AssessorCallBackRequestID).HasColumnName("AssessorCallBackRequestID");
            this.Property(t => t.AssessorID).HasColumnName("AssessorID");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Assessor)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.AssessorID);
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.AssessorCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestID);

        }
    }
}
