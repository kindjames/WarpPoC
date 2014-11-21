using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class ClientAccountManagerMap : EntityTypeConfiguration<ClientAccountManager>
    {
        public ClientAccountManagerMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientAccountManagerId);

            // Properties
            // Table & Column Mappings
            this.ToTable("ClientAccountManager", "Client");
            this.Property(t => t.ClientAccountManagerId).HasColumnName("ClientAccountManagerID");
            this.Property(t => t.ClientId).HasColumnName("ClientID");
            this.Property(t => t.AccountManagerId).HasColumnName("AccountManagerID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountManagers)
                .HasForeignKey(d => d.ClientId);
        }
    }
}
