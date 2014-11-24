using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Permission
    {
        public Permission()
        {
            ArticlePermissions = new List<ArticlePermission>();
            PermissionGroupPermissions = new List<PermissionGroupPermission>();
        }

        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ArticlePermission> ArticlePermissions { get; set; }
        public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
    }
}