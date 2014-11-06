using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AccountingInvoice
    {
        public int AccountingInvoiceID { get; set; }
        public int AccountingClientID { get; set; }
        public int AccountingPeriodID { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public decimal Amount { get; set; }
        public short CurrencyID { get; set; }
        public Nullable<int> CurrencyExchangeRateID { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public short GeneratedByAdminID { get; set; }
        public Nullable<System.DateTime> CancelledDate { get; set; }
        public Nullable<short> CancelledByAdminID { get; set; }
        public virtual AccountingClient AccountingClient { get; set; }
        public virtual AccountingPeriod AccountingPeriod { get; set; }
    }
}
