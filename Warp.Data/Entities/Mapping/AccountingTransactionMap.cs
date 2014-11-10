using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Warp.Data.Entities.Mapping
{
    public class AccountingTransactionMap : EntityTypeConfiguration<AccountingTransaction>
    {
        public AccountingTransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountTransactionID);

            // Properties
            this.Property(t => t.AccountTransactionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("AccountingTransaction");
            this.Property(t => t.AccountTransactionID).HasColumnName("AccountTransactionID");
            this.Property(t => t.VisitID).HasColumnName("VisitID");
            this.Property(t => t.AccountingProductID).HasColumnName("AccountingProductID");
            this.Property(t => t.AssessmentAreaID).HasColumnName("AssessmentAreaID");
            this.Property(t => t.KashFlowID).HasColumnName("KashFlowID");
            this.Property(t => t.AccountingInvoiceID).HasColumnName("AccountingInvoiceID");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Quantity).HasColumnName("Quantity");
            this.Property(t => t.CurrencyID).HasColumnName("CurrencyID");
            this.Property(t => t.CurrencyExchangeRateID).HasColumnName("CurrencyExchangeRateID");
            this.Property(t => t.DateCreated).HasColumnName("DateCreated");
            this.Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Currency)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.CurrencyID);
            this.HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AccountingProductID);
            this.HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AssessmentAreaID);
            this.HasRequired(t => t.Visit)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.VisitID);

        }
    }
}
