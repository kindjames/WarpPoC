using System;

namespace Warp.Data.Entities
{
    public partial class ContactAddressCustomer
    {
        public int ContactAddressCustomer1 { get; set; }
        public int ContactAddressID { get; set; }
        public int CustomerID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
