using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SimpleVisit
    {
        public SimpleVisit()
        {
            this.SimpleVisitQuestionResults = new List<SimpleVisitQuestionResult>();
        }

        public int SimpleVisitID { get; set; }
        public int SimpleVisitTemplateID { get; set; }
        public short VisitStatusID { get; set; }
        public short VisitTypeID { get; set; }
        public int BranchID { get; set; }
        public int AssessorID { get; set; }
        public string IP { get; set; }
        public System.DateTime StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual SimpleVisitTemplate SimpleVisitTemplate { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
        public virtual VisitType VisitType { get; set; }
        public virtual ICollection<SimpleVisitQuestionResult> SimpleVisitQuestionResults { get; set; }
    }
}
