using System;

namespace Warp.Data.Entities
{
    public partial class VisitAssessor
    {
        public int VisitAssessorID { get; set; }
        public int VisitID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public Nullable<int> RemovedByAdminID { get; set; }
        public bool Active { get; set; }
        public bool PreviewedQuestionnaire { get; set; }
        public short RemovalReasonID { get; set; }
        public string RemovalNotes { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual RemovalReason RemovalReason { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
