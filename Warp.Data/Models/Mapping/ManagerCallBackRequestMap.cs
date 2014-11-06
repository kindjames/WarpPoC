using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ManagerCallBackRequestMap : EntityTypeConfiguration<ManagerCallBackRequest>
    {
        public ManagerCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.ManagerCallBackRequestID);

            // Properties
            this.Property(t => t.ManagerCallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ManagerCallBackRequest");
            this.Property(t => t.ManagerCallBackRequestID).HasColumnName("ManagerCallBackRequestID");
            this.Property(t => t.ManagerID).HasColumnName("ManagerID");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");

            // Relationships
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.ManagerCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestID);

        }
    }
}
