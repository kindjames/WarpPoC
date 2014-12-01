using System;

namespace Warp.Data.DbFirst.Entities
{
    public class AssessorCallBackRequest
    {
        public int AssessorCallBackRequestId { get; set; }
        public int AssessorId { get; set; }
        public int CallBackRequestId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}