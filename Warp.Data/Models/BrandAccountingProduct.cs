using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandAccountingProduct
    {
        public int BrandAccountingProductID { get; set; }
        public int BrandID { get; set; }
        public int AccountingProductID { get; set; }
        public decimal DefaultValue { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}
