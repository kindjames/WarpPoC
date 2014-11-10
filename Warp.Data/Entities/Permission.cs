using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Permission
    {
        public Permission()
        {
            this.ArticlePermissions = new List<ArticlePermission>();
            this.PermissionGroupPermissions = new List<PermissionGroupPermission>();
        }

        public int PermissionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ArticlePermission> ArticlePermissions { get; set; }
        public virtual ICollection<PermissionGroupPermission> PermissionGroupPermissions { get; set; }
    }
}
