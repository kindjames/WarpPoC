using System;

namespace Warp.Data.Entities
{
    public partial class CurrencyExchangeRate
    {
        public int CurrencyExchageRateID { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
