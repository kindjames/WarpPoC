using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ForumAssessorReply
    {
        public ForumAssessorReply()
        {
            ForumReportedReplies = new List<ForumReportedReply>();
        }

        public int ForumAssessorReplyId { get; set; }
        public int ForumThreadId { get; set; }
        public int AssessorId { get; set; }
        public string ReplyText { get; set; }
        public bool Display { get; set; }
        public bool Reported { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ForumThread ForumThread { get; set; }
        public virtual ICollection<ForumReportedReply> ForumReportedReplies { get; set; }
    }
}