using System;

namespace Warp.Data.Entities
{
    public partial class AccountingInvoice
    {
        public int AccountingInvoiceID { get; set; }
        public int AccountingClientID { get; set; }
        public int AccountingPeriodID { get; set; }
        public System.DateTime DateOfInvoice { get; set; }
        public decimal Amount { get; set; }
        public short CurrencyID { get; set; }
        public Nullable<int> CurrencyExchangeRateID { get; set; }
        public System.DateTime DateGenerated { get; set; }
        public short GeneratedByAdminID { get; set; }
        public Nullable<System.DateTime> DateCancelled { get; set; }
        public Nullable<short> CancelledByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AccountingClient AccountingClient { get; set; }
        public virtual AccountingPeriod AccountingPeriod { get; set; }
    }
}
