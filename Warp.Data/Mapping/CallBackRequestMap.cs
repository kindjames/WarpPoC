using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class CallBackRequestMap : EntityTypeConfiguration<CallBackRequest>
    {
        public CallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.CallBackRequestId);

            // Properties
            this.Property(t => t.CallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CallBackRequest");
            this.Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            this.Property(t => t.CallBackByAdminId).HasColumnName("CallBackByAdminID");
            this.Property(t => t.Shared).HasColumnName("Shared");
            this.Property(t => t.OwnedByAdminId).HasColumnName("OwnedByAdminID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
