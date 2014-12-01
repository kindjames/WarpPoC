namespace Warp.Data.DbFirst.Entities
{
    public class AccountingTransaction : EntityBase
    {
        public int AccountTransactionId { get; set; }
        public int VisitId { get; set; }
        public int AccountingProductId { get; set; }
        public short AssessmentAreaId { get; set; }
        public int KashFlowId { get; set; }
        public int AccountingInvoiceId { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Quantity { get; set; }
        public int CurrencyId { get; set; }
        public int CurrencyExchangeRateId { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
        public virtual AssessmentArea AssessmentArea { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
