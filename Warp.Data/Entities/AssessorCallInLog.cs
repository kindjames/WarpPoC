using System;

namespace Warp.Data.Entities
{
    public class AssessorCallInLog
    {
        public int AssessorCallInLogId { get; set; }
        public int AssessorId { get; set; }
        public int CallInLogId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CallInLog CallInLog { get; set; }
    }
}