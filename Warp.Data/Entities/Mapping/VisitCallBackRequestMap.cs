using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class VisitCallBackRequestMap : EntityTypeConfiguration<VisitCallBackRequest>
    {
        public VisitCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.VisitCallBackRequestID);

            // Properties
            this.Property(t => t.VisitCallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VisitCallBackRequest");
            this.Property(t => t.VisitCallBackRequestID).HasColumnName("VisitCallBackRequestID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.VisitCallBackRequests)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
