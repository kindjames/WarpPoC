using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientCallBackRequestMap : EntityTypeConfiguration<ClientCallBackRequest>
    {
        public ClientCallBackRequestMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCallBackRequestID);

            // Properties
            this.Property(t => t.ClientCallBackRequestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientCallBackRequest");
            this.Property(t => t.ClientCallBackRequestID).HasColumnName("ClientCallBackRequestID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.CallBackRequestID).HasColumnName("CallBackRequestID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.CallBackRequest)
                .WithMany(t => t.ClientCallBackRequests)
                .HasForeignKey(d => d.CallBackRequestID);

        }
    }
}
