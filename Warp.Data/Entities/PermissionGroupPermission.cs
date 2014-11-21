using System;

namespace Warp.Data.Entities
{
    public class PermissionGroupPermission
    {
        public int PermissionGroupPermissionId { get; set; }
        public int PermissionGroupId { get; set; }
        public int PermissionId { get; set; }
        public DateTime DateCreated { get; set; }
        public int AddedByAdminId { get; set; }
        public bool Active { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int DeactivatedByAdminId { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
    }
}