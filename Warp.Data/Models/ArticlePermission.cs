using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ArticlePermission
    {
        public int ArticlePermissionID { get; set; }
        public int ArticleID { get; set; }
        public int PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        public virtual Article Article { get; set; }
    }
}
