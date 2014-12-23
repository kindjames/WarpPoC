using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AccountingInvoiceMap : EntityTypeConfiguration<AccountingInvoice>
    {
        public AccountingInvoiceMap()
        {
            // Primary Key
            HasKey(t => t.AccountingInvoiceId);

            // Properties
            Property(t => t.AccountingInvoiceId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AccountingInvoice");
            Property(t => t.AccountingInvoiceId).HasColumnName("AccountingInvoiceID");
            Property(t => t.AccountingClientId).HasColumnName("AccountingClientID");
            Property(t => t.AccountingPeriodId).HasColumnName("AccountingPeriodID");
            Property(t => t.DateOfInvoice).HasColumnName("DateOfInvoice");
            Property(t => t.Amount).HasColumnName("Amount");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            Property(t => t.DateGenerated).HasColumnName("DateGenerated");
            Property(t => t.GeneratedByAdminId).HasColumnName("GeneratedByAdminID");
            Property(t => t.DateCancelled).HasColumnName("DateCancelled");
            Property(t => t.CancelledByAdminId).HasColumnName("CancelledByAdminID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.AccountingClient)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingClientId);
            HasRequired(t => t.AccountingPeriod)
                .WithMany(t => t.AccountingInvoices)
                .HasForeignKey(d => d.AccountingPeriodId);

        }
    }
}
