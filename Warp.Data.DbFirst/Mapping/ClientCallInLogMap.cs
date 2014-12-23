using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientCallInLogMap : EntityTypeConfiguration<ClientCallInLog>
    {
        public ClientCallInLogMap()
        {
            // Primary Key
            HasKey(t => t.ClientCallInLogId);

            // Properties
            Property(t => t.ClientCallInLogId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("ClientCallInLog");
            Property(t => t.ClientCallInLogId).HasColumnName("ClientCallInLogID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.CallInLogId).HasColumnName("CallInLogID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.ClientId);
            HasRequired(t => t.CallInLog)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.CallInLogId);

        }
    }
}
