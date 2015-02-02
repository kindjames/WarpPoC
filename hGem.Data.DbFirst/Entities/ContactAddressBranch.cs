using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ContactAddressBranch : EntityBase
    {
        public int ContactAddressBranchId { get; set; }
        public int ContactAddressId { get; set; }
        public int BranchId { get; set; }
        public int ContactAddressTypeId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int? AssignedByAdminId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ContactAddress ContactAddress { get; set; }
        public virtual ContactAddressType ContactAddressType { get; set; }
    }
}
