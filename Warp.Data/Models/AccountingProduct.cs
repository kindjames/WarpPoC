using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AccountingProduct
    {
        public AccountingProduct()
        {
            this.AccountingTransactions = new List<AccountingTransaction>();
            this.BranchAccountingProducts = new List<BranchAccountingProduct>();
            this.BrandAccountingProducts = new List<BrandAccountingProduct>();
            this.ClientAccountingProducts = new List<ClientAccountingProduct>();
            this.QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
        }

        public int AccountingProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DefaultValue { get; set; }
        public Nullable<int> KashFlowID { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<BranchAccountingProduct> BranchAccountingProducts { get; set; }
        public virtual ICollection<BrandAccountingProduct> BrandAccountingProducts { get; set; }
        public virtual ICollection<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public virtual ICollection<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
    }
}
