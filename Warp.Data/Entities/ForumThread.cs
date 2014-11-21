using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ForumThread
    {
        public ForumThread()
        {
            ForumAdminReplies = new List<ForumAdminReply>();
            ForumAssessorReplies = new List<ForumAssessorReply>();
        }

        public int ForumThreadId { get; set; }
        public short ForumCategoryId { get; set; }
        public int AssessorId { get; set; }
        public string Title { get; set; }
        public string ThreadText { get; set; }
        public int Views { get; set; }
        public bool Locked { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ICollection<ForumAdminReply> ForumAdminReplies { get; set; }
        public virtual ICollection<ForumAssessorReply> ForumAssessorReplies { get; set; }
        public virtual ForumCategory ForumCategory { get; set; }
    }
}