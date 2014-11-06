using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientAccountingProduct
    {
        public int ClientAccountingProductID { get; set; }
        public int ClientID { get; set; }
        public int AccountingProductID { get; set; }
        public Nullable<decimal> DefaultValue { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}
