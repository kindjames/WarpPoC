using System;

namespace Warp.Data.Entities
{
    public partial class CustomerClient
    {
        public int CustomerClientID { get; set; }
        public int CustomerID { get; set; }
        public int ClientID { get; set; }
        public int CustomerLinkStatusID { get; set; }
        public bool PrimaryCustomer { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual CustomerLinkStatu CustomerLinkStatu { get; set; }
    }
}
