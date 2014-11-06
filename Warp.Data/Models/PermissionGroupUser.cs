using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PermissionGroupUser
    {
        public int PermissionGroupUserID { get; set; }
        public int PermissionGroupID { get; set; }
        public int UserRoleID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public Nullable<System.DateTime> DeactivateDate { get; set; }
        public Nullable<int> DeactivatedByAdminID { get; set; }
        public bool Active { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
