using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AccountingInvoiceMap : EntityTypeConfiguration<AccountingInvoice>
    {
        public AccountingInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountingInvoiceID);

            // Properties
            this.Property(t => t.AccountingInvoiceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountingInvoice");
            this.Property(t => t.AccountingInvoiceID).HasColumnName("AccountingInvoiceID");
            this.Property(t => t.AccountingClientID).HasColumnName("AccountingClientID");
            this.Property(t => t.AccountingPeriodID).HasColumnName("AccountingPeriodID");
            this.Property(t => t.DateOfInvoice).HasColumnName("DateOfInvoice");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateID).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.DateGenerated).HasColumnName("DateGenerated");
            this.Property(t => t.GeneratedByAdminID).HasColumnName("GeneratedByAdminID");
            this.Property(t => t.DateCancelled).HasColumnName("DateCancelled");
            this.Property(t => t.CancelledByAdminID).HasColumnName("CancelledByAdminID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.AccountingClient)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingClientID);
            this.HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingPeriodID);

        }
    }
}
