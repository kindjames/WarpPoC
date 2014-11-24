using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class CallInLog
    {
        public CallInLog()
        {
            AssessorCallInLogs = new List<AssessorCallInLog>();
            ClientCallInLogs = new List<ClientCallInLog>();
            VisitCallInLogs = new List<VisitCallInLog>();
        }

        public int CallInLogId { get; set; }
        public int EnteredByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Notes { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool HighPriority { get; set; }
        public bool Active { get; set; }
        public bool Visible { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<AssessorCallInLog> AssessorCallInLogs { get; set; }
        public virtual ICollection<ClientCallInLog> ClientCallInLogs { get; set; }
        public virtual ICollection<VisitCallInLog> VisitCallInLogs { get; set; }
    }
}