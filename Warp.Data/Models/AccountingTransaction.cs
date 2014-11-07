using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AccountingTransaction
    {
        public int AccountTransactionID { get; set; }
        public int VisitID { get; set; }
        public int AccountingProductID { get; set; }
        public short AssessmentAreaID { get; set; }
        public int KashFlowID { get; set; }
        public int AccountingInvoiceID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public int CurrencyID { get; set; }
        public int CurrencyExchangeRateID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
        public virtual AssessmentArea AssessmentArea { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
