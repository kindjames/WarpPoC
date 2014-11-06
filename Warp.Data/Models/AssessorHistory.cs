using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorHistory
    {
        public int AssessorHistoryID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short AssessorStatusID { get; set; }
        public short AdminID { get; set; }
        public short AssessorStatusChangeReasonID { get; set; }
        public short AssessorLevelID { get; set; }
        public string Comment { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AssessorLevel AssessorLevel { get; set; }
        public virtual AssessorStatu AssessorStatu { get; set; }
        public virtual AssessorStatusChangeReason AssessorStatusChangeReason { get; set; }
    }
}
