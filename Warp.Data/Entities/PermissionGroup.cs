using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class PermissionGroup
    {
        public PermissionGroup()
        {
            PermissionGroupUsers = new List<PermissionGroupUser>();
            PermissionGroupPermissions = new List<PermissionGroupPermission>();
        }

        public int PermissionGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PermissionGroupUser> PermissionGroupUsers { get; set; }
        public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
    }
}