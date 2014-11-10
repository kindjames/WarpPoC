using System;

namespace Warp.Data.Entities
{
    public partial class ClientAccountingProduct
    {
        public int ClientAccountingProductID { get; set; }
        public int ClientID { get; set; }
        public int AccountingProductID { get; set; }
        public Nullable<decimal> DefaultValue { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual AccountingProduct AccountingProduct { get; set; }
    }
}
