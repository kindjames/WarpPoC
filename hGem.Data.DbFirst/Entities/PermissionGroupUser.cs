using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PermissionGroupUser
    {
        public int PermissionGroupUserId { get; set; }
        public int PermissionGroupId { get; set; }
        public int UserRoleId { get; set; }
        public DateTime DateCreated { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int? DeactivatedByAdminId { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual PermissionGroup PermissionGroup { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}