using System;

namespace Warp.Data.Entities
{
    public class AssessorHistory
    {
        public int AssessorHistoryId { get; set; }
        public int AssessorId { get; set; }
        public short AssessorStatusId { get; set; }
        public short AdminId { get; set; }
        public short AssessorStatusChangeReasonId { get; set; }
        public short AssessorLevelId { get; set; }
        public string Comment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AssessorLevel AssessorLevel { get; set; }
        public virtual AssessorStatus AssessorStatus { get; set; }
        public virtual AssessorStatusChangeReason AssessorStatusChangeReason { get; set; }
    }
}