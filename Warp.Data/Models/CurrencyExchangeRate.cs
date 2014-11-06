using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CurrencyExchangeRate
    {
        public int CurrencyExchageRateID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int CurrencyID { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<System.DateTime> ValidUntil { get; set; }
        public virtual Currency Currency { get; set; }
    }
}
