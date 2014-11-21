using System;

namespace Warp.Data.Entities
{
    public class VisitCallInLog
    {
        public int VisitCallInLogId { get; set; }
        public int VisitId { get; set; }
        public int CallInLogId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CallInLog CallInLog { get; set; }
        public virtual Visit Visit { get; set; }
    }
}