using System;

namespace Warp.Data.Entities
{
    public partial class BranchAccountingProduct
    {
        public int BranchAccountingProductID { get; set; }
        public int BranchID { get; set; }
        public int AccountingProductID { get; set; }
        public Nullable<decimal> DefaultValue { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}
