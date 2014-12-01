using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitAssessor
    {
        public int VisitAssessorId { get; set; }
        public int VisitId { get; set; }
        public int AssessorId { get; set; }
        public DateTime DateCreated { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateUpdated { get; set; }
        public int? RemovedByAdminId { get; set; }
        public bool Active { get; set; }
        public bool PreviewedQuestionnaire { get; set; }
        public short RemovalReasonId { get; set; }
        public string RemovalNotes { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual RemovalReason RemovalReason { get; set; }
        public virtual Visit Visit { get; set; }
    }
}