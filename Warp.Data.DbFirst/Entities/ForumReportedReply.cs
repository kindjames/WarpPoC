using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ForumReportedReply
    {
        public int ForumReportedReplyId { get; set; }
        public int ForumAssessorReplyId { get; set; }
        public int AssessorId { get; set; }
        public string ReportText { get; set; }
        public DateTime? DateReportAdded { get; set; }
        public int? CheckedByAdminId { get; set; }
        public bool Reviewed { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Remove { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ForumAssessorReply ForumAssessorReply { get; set; }
    }
}