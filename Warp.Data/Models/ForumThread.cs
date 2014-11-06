using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ForumThread
    {
        public ForumThread()
        {
            this.ForumAdminReplies = new List<ForumAdminReply>();
            this.ForumAssessorReplies = new List<ForumAssessorReply>();
        }

        public int ForumThreadID { get; set; }
        public short ForumCategoryID { get; set; }
        public int AssessorID { get; set; }
        public string Title { get; set; }
        public string ThreadText { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int Views { get; set; }
        public bool Locked { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ICollection<ForumAdminReply> ForumAdminReplies { get; set; }
        public virtual ICollection<ForumAssessorReply> ForumAssessorReplies { get; set; }
        public virtual ForumCategory ForumCategory { get; set; }
    }
}
