using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ForumCategory
    {
        public ForumCategory()
        {
            ForumThreads = new List<ForumThread>();
        }

        public short ForumCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public int AddedByAdminId { get; set; }
        public bool Locked { get; set; }
        public DateTime? DateDeactivated { get; set; }
        public int? DeactivatedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ForumThread> ForumThreads { get; set; }
    }
}