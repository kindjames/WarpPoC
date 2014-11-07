using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ForumCategory
    {
        public ForumCategory()
        {
            this.ForumThreads = new List<ForumThread>();
        }

        public short ForumCategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int AddedByAdminID { get; set; }
        public bool Locked { get; set; }
        public Nullable<System.DateTime> DateDeactivated { get; set; }
        public Nullable<int> DeactivatedByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ForumThread> ForumThreads { get; set; }
    }
}
