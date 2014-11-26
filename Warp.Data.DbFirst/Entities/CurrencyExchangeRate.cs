using System;

namespace Warp.Data.DbFirst.Entities
{
    public class CurrencyExchangeRate
    {
        public int CurrencyExchageRateId { get; set; }
        public int CurrencyId { get; set; }
        public double? Rate { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Currency Currency { get; set; }
    }
}