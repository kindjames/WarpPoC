using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.Entities;

namespace Warp.Data.Mapping
{
    public class AccountingTransactionMap : EntityTypeConfiguration<AccountingTransaction>
    {
        public AccountingTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountTransactionId);

            // Properties
            this.Property(t => t.AccountTransactionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountingTransaction");
            this.Property(t => t.AccountTransactionId).HasColumnName("AccountTransactionID");
            this.Property(t => t.VisitId).HasColumnName("VisitID");
            this.Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            this.Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            this.Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            this.Property(t => t.AccountingInvoiceId).HasColumnName("AccountingInvoiceID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.CurrencyId);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AccountingProductId);
            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AssessmentAreaId);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
