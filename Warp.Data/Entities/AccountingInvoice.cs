using System;

namespace Warp.Data.Entities
{
    public class AccountingInvoice
    {
        public int AccountingInvoiceId { get; set; }
        public int AccountingClientId { get; set; }
        public int AccountingPeriodId { get; set; }
        public DateTime DateOfInvoice { get; set; }
        public decimal Amount { get; set; }
        public short CurrencyId { get; set; }
        public int? CurrencyExchangeRateId { get; set; }
        public DateTime DateGenerated { get; set; }
        public short GeneratedByAdminId { get; set; }
        public DateTime? DateCancelled { get; set; }
        public short? CancelledByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AccountingClient AccountingClient { get; set; }
        public virtual AccountingPeriod AccountingPeriod { get; set; }
    }
}