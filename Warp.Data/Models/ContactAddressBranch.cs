using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ContactAddressBranch
    {
        public int ContactAddressBranchID { get; set; }
        public int ContactAddressID { get; set; }
        public int BranchID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public int AssignedByAdminId { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
