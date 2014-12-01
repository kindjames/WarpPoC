using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientCallBackRequestMap : EntityTypeConfiguration<ClientCallBackRequest>
    {
        public ClientCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCallBackRequestId);

            // Properties
            this.Property(t => t.ClientCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientCallBackRequest");
            this.Property(t => t.ClientCallBackRequestId).HasColumnName("ClientCallBackRequestID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
