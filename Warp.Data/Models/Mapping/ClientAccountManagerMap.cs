using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class ClientAccountManagerMap : EntityTypeConfiguration<ClientAccountManager>
    {
        public ClientAccountManagerMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientAccountManagerID);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientAccountManager", "Client");
            this.Property(t => t.ClientAccountManagerID).HasColumnName("ClientAccountManagerID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.AccountManagerID).HasColumnName("AccountManagerID");
            this.Property(t => t.Created).HasColumnName("Created");
            this.Property(t => t.LastUpdated).HasColumnName("LastUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountManagers)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
