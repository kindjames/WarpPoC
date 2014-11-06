using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Models.Mapping
{
    public class Client1Map : EntityTypeConfiguration<Client1>
    {
        public Client1Map()
        {
            // Primary Key
            this.HasKey(t => t.ClientID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ClientStatusID).HasColumnName("ClientStatusID");
            this.Property(t => t.CapsuleID).HasColumnName("CapsuleID");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.AccountManagerAdminID).HasColumnName("AccountManagerAdminID");
            this.Property(t => t.AssessorBanDays).HasColumnName("AssessorBanDays");
            this.Property(t => t.ClientContactManagerID).HasColumnName("ClientContactManagerID");
            this.Property(t => t.Visible).HasColumnName("Visible");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.ClientStatus1)
                .WithMany(t => t.Client1)
                .HasForeignKey(d => d.ClientStatusID);

        }
    }
}
