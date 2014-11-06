using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PermissionGroup
    {
        public PermissionGroup()
        {
            this.PermissionGroupUsers = new List<PermissionGroupUser>();
            this.PermissionGroupPermissions = new List<PermissionGroupPermission>();
        }

        public int PermissionGroupID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
    }
}
