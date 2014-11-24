using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SimpleVisit
    {
        public SimpleVisit()
        {
            SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
        }

        public int SimpleVisitId { get; set; }
        public int SimpleVisitTemplateId { get; set; }
        public short VisitStatusId { get; set; }
        public short VisitTypeId { get; set; }
        public int BranchId { get; set; }
        public int AssessorId { get; set; }
        public string IP { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual SimpleVisitTemplate SimpleVisitTemplate { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
    }
}