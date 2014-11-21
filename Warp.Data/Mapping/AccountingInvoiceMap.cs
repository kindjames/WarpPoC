using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AccountingInvoiceMap : EntityTypeConfiguration<AccountingInvoice>
    {
        public AccountingInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountingInvoiceId);

            // Properties
            this.Property(t => t.AccountingInvoiceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountingInvoice");
            this.Property(t => t.AccountingInvoiceId).HasColumnName("AccountingInvoiceID");
            this.Property(t => t.AccountingClientId).HasColumnName("AccountingClientID");
            this.Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            this.Property(t => t.DateOfInvoice).HasColumnName("DateOfInvoice");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.DateGenerated).HasColumnName("DateGenerated");
            this.Property(t => t.GeneratedByAdminId).HasColumnName("GeneratedByAdminID");
            this.Property(t => t.DateCancelled).HasColumnName("DateCancelled");
            this.Property(t => t.CancelledByAdminId).HasColumnName("CancelledByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingClient)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingClientId);
            this.HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingPeriodId);

        }
    }
}
