using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AccountingClientMap : EntityTypeConfiguration<AccountingClient>
    {
        public AccountingClientMap()
        {
            // Primary Key
            HasKey(t => t.AccountingClientId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("AccountingClient");
            Property(t => t.AccountingClientId).HasColumnName("AccountingClientID");
            Property(t => t.ClientId).HasColumnName("ClientID");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Client)
                .WithMany(t => t.AccountingClients)
                .HasForeignKey(d => d.ClientId);

        }
    }
}
