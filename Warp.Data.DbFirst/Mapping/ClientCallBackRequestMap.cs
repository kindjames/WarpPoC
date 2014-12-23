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
            HasKey(t => t.ClientCallBackRequestId);

            // Properties
            Property(t => t.ClientCallBackRequestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ClientCallBackRequest");
            Property(t => t.ClientCallBackRequestId).HasColumnName("ClientCallBackRequestID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.CallBackRequestId).HasColumnName("CallBackRequestID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestId);

        }
    }
}
