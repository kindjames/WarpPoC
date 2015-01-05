using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class ClientAccountManagerMap : EntityTypeConfiguration<ClientAccountManager>
    {
        public ClientAccountManagerMap()
        {
            // Primary Key
            HasKey(t => t.ClientAccountManagerId);

            // Properties
            // Table & Column Mappings
            ToTable("ClientAccountManager", "Client");
            Property(t => t.ClientAccountManagerId).HasColumnName("ClientAccountManagerID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.AccountManagerId).HasColumnName("AccountManagerID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.ClientAccountManagers)
                .HasForeignKey(d => d.ClientId);
        }
    }
}
