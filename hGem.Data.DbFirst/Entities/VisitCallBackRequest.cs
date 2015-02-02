using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitCallBackRequest
    {
        public int VisitCallBackRequestId { get; set; }
        public int VisitId { get; set; }
        public int CallBackRequestId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
        public virtual Visit Visit { get; set; }
    }
}