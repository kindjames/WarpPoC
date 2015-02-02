using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PersonBranch
    {
        public int PersonBranchId { get; set; }
        public int PersonId { get; set; }
        public int BranchId { get; set; }
        public int? PermissionTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}