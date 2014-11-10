using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class CallInLog
    {
        public CallInLog()
        {
            this.AssessorCallInLogs = new List<AssessorCallInLog>();
            this.ClientCallInLogs = new List<ClientCallInLog>();
            this.VisitCallInLogs = new List<VisitCallInLog>();
        }

        public int CallInLogID { get; set; }
        public int EnteredByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Notes { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public bool HighPriority { get; set; }
        public bool Active { get; set; }
        public bool Visible { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorCallInLog> AssessorCallInLogs { get; set; }
        public virtual ICollection<ClientCallInLog> ClientCallInLogs { get; set; }
        public virtual ICollection<VisitCallInLog> VisitCallInLogs { get; set; }
    }
}
