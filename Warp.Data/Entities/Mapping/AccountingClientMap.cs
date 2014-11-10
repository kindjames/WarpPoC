using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AccountingClientMap : EntityTypeConfiguration<AccountingClient>
    {
        public AccountingClientMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountingClientID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("AccountingClient");
            this.Property(t => t.AccountingClientID).HasColumnName("AccountingClientID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Client)
                .WithMany(t => t.AccountingClients)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
