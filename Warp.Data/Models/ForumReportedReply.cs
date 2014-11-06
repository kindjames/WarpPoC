using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ForumReportedReply
    {
        public int ForumReportedReplyID { get; set; }
        public int ForumAssessorReplyID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public string ReportText { get; set; }
        public Nullable<System.DateTime> ReportAdded { get; set; }
        public Nullable<int> CheckedByAdminID { get; set; }
        public bool Reviewed { get; set; }
        public bool Remove { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ForumAssessorReply ForumAssessorReply { get; set; }
    }
}
