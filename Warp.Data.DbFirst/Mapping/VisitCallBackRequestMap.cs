using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class VisitCallBackRequestMap : EntityTypeConfiguration<VisitCallBackRequest>
    {
        public VisitCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitCallBackRequestId);

            // Properties
            this.Property(t => t.VisitCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitCallBackRequest");
            this.Property(t => t.VisitCallBackRequestId).HasColumnName("VisitCallBackRequestID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
