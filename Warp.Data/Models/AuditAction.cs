using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AuditAction
    {
        public AuditAction()
        {
            this.AuditAdminEvents = new List<AuditAdminEvent>();
            this.AuditAssessorEvents = new List<AuditAssessorEvent>();
            this.AuditManagerEvents = new List<AuditManagerEvent>();
            this.AuditPersonEvents = new List<AuditPersonEvent>();
        }

        public byte AuditActionID { get; set; }
        public string ActionName { get; set; }
        public virtual ICollection<AuditAdminEvent> AuditAdminEvents { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<AuditManagerEvent> AuditManagerEvents { get; set; }
        public virtual ICollection<AuditPersonEvent> AuditPersonEvents { get; set; }
    }
}
