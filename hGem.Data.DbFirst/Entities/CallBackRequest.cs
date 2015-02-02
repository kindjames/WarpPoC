using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CallBackRequest
    {
        public CallBackRequest()
        {
            AssessorCallBackRequests = new List<AssessorCallBackRequest>();
            ClientCallBackRequests = new List<ClientCallBackRequest>();
            PersonCallBackRequests = new List<PersonCallBackRequest>();
            VisitCallBackRequests = new List<VisitCallBackRequest>();
        }

        public int CallBackRequestId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Notes { get; set; }
        public int EnteredByAdminId { get; set; }
        public int CallBackByAdminId { get; set; }
        public bool Shared { get; set; }
        public int? OwnedByAdminId { get; set; }
        public bool Visible { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorCallBackRequest> AssessorCallBackRequests { get; set; }
        public virtual ICollection<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public virtual ICollection<PersonCallBackRequest> PersonCallBackRequests { get; set; }
        public virtual ICollection<VisitCallBackRequest> VisitCallBackRequests { get; set; }
    }
}