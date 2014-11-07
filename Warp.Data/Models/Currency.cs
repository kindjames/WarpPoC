using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Currency
    {
        public Currency()
        {
            this.Branches = new List<Branch>();
            this.AccountingTransactions = new List<AccountingTransaction>();
            this.AssessorExpenses = new List<AssessorExpense>();
            this.CurrencyExchangeRates = new List<CurrencyExchangeRate>();
            this.GeographicCountries = new List<GeographicCountry>();
        }

        public int CurrencyID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }
        public virtual ICollection<GeographicCountry> GeographicCountries { get; set; }
    }
}
