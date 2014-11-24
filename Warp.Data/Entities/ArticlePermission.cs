using System;

namespace Warp.Data.Entities
{
    public class ArticlePermission
    {
        public int ArticlePermissionId { get; set; }
        public int ArticleId { get; set; }
        public int PermissionId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Article Article { get; set; }
    }
}