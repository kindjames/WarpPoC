using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressCustomer
    {
        public int ContactAddressCustomer1 { get; set; }
        public int ContactAddressID { get; set; }
        public int CustomerID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
