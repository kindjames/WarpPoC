using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CallBackRequest
    {
        public CallBackRequest()
        {
            this.AssessorCallBackRequests = new List<AssessorCallBackRequest>();
            this.ClientCallBackRequests = new List<ClientCallBackRequest>();
            this.ManagerCallBackRequests = new List<ManagerCallBackRequest>();
            this.PersonCallBackRequests = new List<PersonCallBackRequest>();
            this.VisitCallBackRequests = new List<VisitCallBackRequest>();
        }

        public int CallBackRequestID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public string Notes { get; set; }
        public int EnteredByAdminID { get; set; }
        public int CallBackByAdminID { get; set; }
        public bool Shared { get; set; }
        public Nullable<int> OwnedByAdminID { get; set; }
        public bool Active { get; set; }
        public bool Visible { get; set; }
        public virtual ICollection<AssessorCallBackRequest> AssessorCallBackRequests { get; set; }
        public virtual ICollection<ClientCallBackRequest> ClientCallBackRequests { get; set; }
        public virtual ICollection<ManagerCallBackRequest> ManagerCallBackRequests { get; set; }
        public virtual ICollection<PersonCallBackRequest> PersonCallBackRequests { get; set; }
        public virtual ICollection<VisitCallBackRequest> VisitCallBackRequests { get; set; }
    }
}
