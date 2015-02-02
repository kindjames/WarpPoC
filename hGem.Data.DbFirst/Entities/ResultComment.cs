using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ResultComment
    {
        public int ResultCommentId { get; set; }
        public int AssessmentId { get; set; }
        public int AssessorId { get; set; }
        public string AssessorComments { get; set; }
        public int? AdminId { get; set; }
        public string AdminComments { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessment Assessment { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}