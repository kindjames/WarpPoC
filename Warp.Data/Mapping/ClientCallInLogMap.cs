using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientCallInLogMap : EntityTypeConfiguration<ClientCallInLog>
    {
        public ClientCallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCallInLogId);

            // Properties
            this.Property(t => t.ClientCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientCallInLog");
            this.Property(t => t.ClientCallInLogId).HasColumnName("ClientCallInLogID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.ClientId);
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.CallInLogId);

        }
    }
}
