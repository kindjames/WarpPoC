using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Warp.Data.DbFirst.Entities;

namespace Warp.Data.DbFirst.Mapping
{
    public class AccountingTransactionMap : EntityTypeConfiguration<AccountingTransaction>
    {
        public AccountingTransactionMap()
        {
            // Primary Key
            HasKey(t => t.AccountTransactionId);

            // Properties
            Property(t => t.AccountTransactionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            ToTable("AccountingTransaction");
            Property(t => t.AccountTransactionId).HasColumnName("AccountTransactionID");
            Property(t => t.VisitId).HasColumnName("VisitID");
            Property(t => t.AccountingProductId).HasColumnName("AccountingProductID");
            Property(t => t.AssessmentAreaId).HasColumnName("AssessmentAreaID");
            Property(t => t.KashFlowId).HasColumnName("KashFlowID");
            Property(t => t.AccountingInvoiceId).HasColumnName("AccountingInvoiceID");
            Property(t => t.Amount).HasColumnName("Amount");
            Property(t => t.Quantity).HasColumnName("Quantity");
            Property(t => t.CurrencyId).HasColumnName("CurrencyID");
            Property(t => t.CurrencyExchangeRateId).HasColumnName("CurrencyExchangeRateID");
            Property(t => t.DateCreated).HasColumnName("DateCreated");
            Property(t => t.DateUpdated).HasColumnName("DateUpdated");
            Property(t => t.Active).HasColumnName("Active");

            // Relationships
            HasRequired(t => t.Currency)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.CurrencyId);
            HasRequired(t => t.AccountingProduct)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AccountingProductId);
            HasRequired(t => t.AssessmentArea)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.AssessmentAreaId);
            HasRequired(t => t.Visit)
                .WithMany(t => t.AccountingTransactions)
                .HasForeignKey(d => d.VisitId);

        }
    }
}
