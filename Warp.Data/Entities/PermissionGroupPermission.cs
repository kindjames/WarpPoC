using System;

namespace Warp.Data.Entities
{
    public partial class PermissionGroupPermission
    {
        public int PermissionGroupPermissionID { get; set; }
        public int PermissionGroupID { get; set; }
        public int PermissionID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int AddedByAdminID { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> DateDeactivated { get; set; }
        public int DeactivatedByAdminID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
    }
}
