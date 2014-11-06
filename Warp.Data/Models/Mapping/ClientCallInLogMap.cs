using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientCallInLogMap : EntityTypeConfiguration<ClientCallInLog>
    {
        public ClientCallInLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientCallInLogID);

            // Properties
            this.Property(t => t.ClientCallInLogID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("ClientCallInLog");
            this.Property(t => t.ClientCallInLogID).HasColumnName("ClientCallInLogID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.CallInLogID).HasColumnName("CallInLogID");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.CallInLog)
                .WithMany(t => t.ClientCallInLogs)
                .HasForeignKey(d => d.CallInLogID);

        }
    }
}
