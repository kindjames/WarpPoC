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
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public Nullable<System.DateTime> DeactivateDate { get; set; }
        public Nullable<int> DeactivatedByAdminID { get; set; }
        public virtual ICollection<ForumThread> ForumThreads { get; set; }
    }
}
