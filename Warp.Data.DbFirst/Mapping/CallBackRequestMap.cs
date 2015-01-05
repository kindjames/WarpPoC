using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class CallBackRequestMap : EntityTypeConfiguration<CallBackRequest>
    {
        public CallBackRequestMap()
        {
            // Primary Key
            HasKey(t => t.CallBackRequestId);

            // Properties
            Property(t => t.CallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Notes)
                .IsRequired()
                .HasMaxLength(500);

            // Table & Column Mappings
            ToTable("CallBackRequest");
            Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            Property(t => t.StartTime).HasColumnName("StartTime");
            Property(t => t.EndTime).HasColumnName("EndTime");
            Property(t => t.Notes).HasColumnName("Notes");
            Property(t => t.EnteredByAdminId).HasColumnName("EnteredByAdminID");
            Property(t => t.CallBackByAdminId).HasColumnName("CallBackByAdminID");
            Property(t => t.Shared).HasColumnName("Shared");
            Property(t => t.OwnedByAdminId).HasColumnName("OwnedByAdminID");
            Property(t => t.Visible).HasColumnName("Visible");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");
        }
    }
}
