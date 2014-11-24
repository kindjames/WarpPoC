using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AuditAction
    {
        public AuditAction()
        {
            AuditAdminEvents = new List<AuditAdminEvent>();
            AuditAssessorEvents = new List<AuditAssessorEvent>();
            AuditPersonEvents = new List<AuditPersonEvent>();
        }

        public byte AuditActionId { get; set; }
        public string ActionName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditAdminEvent> AuditAdminEvents { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<AuditPersonEvent> AuditPersonEvents { get; set; }
    }
}