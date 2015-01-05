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
            HasKey(t => t.VisitCallBackRequestId);

            // Properties
            Property(t => t.VisitCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("VisitCallBackRequest");
            Property(t => t.VisitCallBackRequestId).HasColumnName("VisitCallBackRequestID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
