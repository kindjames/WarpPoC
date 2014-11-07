using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class CallBackRequestMap : EntityTypeConfiguration<CallBackRequest>
    {
        public CallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.CallBackRequestID);

            // Properties
            this.Property(t => t.CallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("CallBackRequest");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");
            this.Property(t => t.StartTime).HasColumnName("StartTime");
            this.Property(t => t.EndTime).HasColumnName("EndTime");
            this.Property(t => t.Notes).HasColumnName("Notes");
            this.Property(t => t.EnteredByAdminID).HasColumnName("EnteredByAdminID");
            this.Property(t => t.CallBackByAdminID).HasColumnName("CallBackByAdminID");
            this.Property(t => t.Shared).HasColumnName("Shared");
            this.Property(t => t.OwnedByAdminID).HasColumnName("OwnedByAdminID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");
        }
    }
}
