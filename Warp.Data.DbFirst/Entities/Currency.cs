using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Currency : EntityBase
    {
        public Currency()
        {
            Branches = new List<Branch>();
            AccountingTransactions = new List<AccountingTransaction>();
            AssessorExpenses = new List<AssessorExpense>();
            CurrencyExchangeRates = new List<CurrencyExchangeRate>();
            GeographicCountries = new List<GeographicCountry>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }
        public virtual ICollection<GeographicCountry> GeographicCountries { get; set; }
    }
}
