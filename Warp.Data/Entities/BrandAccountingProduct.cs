using System;

namespace Warp.Data.Entities
{
    public partial class BrandAccountingProduct
    {
        public int BrandAccountingProductID { get; set; }
        public int BrandID { get; set; }
        public int AccountingProductID { get; set; }
        public decimal DefaultValue { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}
