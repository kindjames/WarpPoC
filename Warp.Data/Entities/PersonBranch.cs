using System;

namespace Warp.Data.Entities
{
    public partial class PersonBranch
    {
        public int PersonBranchID { get; set; }
        public int PersonID { get; set; }
        public int BranchID { get; set; }
        public Nullable<int> PermissionTypeID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
    }
}
