using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AccountingProduct : EntityBase
    {
        public AccountingProduct()
        {
            AccountingTransactions = new List<AccountingTransaction>();
            BranchAccountingProducts = new List<BranchAccountingProduct>();
            BrandAccountingProducts = new List<BrandAccountingProduct>();
            ClientAccountingProducts = new List<ClientAccountingProduct>();
            QuestionnaireAccountingProducts = new List<QuestionnaireAccountingProduct>();
        }

        public int AccountingProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DefaultValue { get; set; }
        public int? KashFlowId { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<BranchAccountingProduct> BranchAccountingProducts { get; set; }
        public virtual ICollection<BrandAccountingProduct> BrandAccountingProducts { get; set; }
        public virtual ICollection<ClientAccountingProduct> ClientAccountingProducts { get; set; }
        public virtual ICollection<QuestionnaireAccountingProduct> QuestionnaireAccountingProducts { get; set; }
    }
}