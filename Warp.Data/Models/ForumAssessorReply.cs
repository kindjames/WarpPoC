using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ForumAssessorReply
    {
        public ForumAssessorReply()
        {
            this.ForumReportedReplies = new List<ForumReportedReply>();
        }

        public int ForumAssessorReplyID { get; set; }
        public int ForumThreadID { get; set; }
        public int AssessorID { get; set; }
        public string ReplyText { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool Display { get; set; }
        public bool Reported { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ForumThread ForumThread { get; set; }
        public virtual ICollection<ForumReportedReply> ForumReportedReplies { get; set; }
    }
}
