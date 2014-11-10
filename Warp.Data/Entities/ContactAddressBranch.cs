using System;

namespace Warp.Data.Entities
{
    public partial class ContactAddressBranch
    {
        public int ContactAddressBranchID { get; set; }
        public int ContactAddressID { get; set; }
        public int BranchID { get; set; }
        public int ContactAddressTypeID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<int> AssignedByAdminId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
