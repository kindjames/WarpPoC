using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class AuditAction
    {
        public AuditAction()
        {
            this.AuditAdminEvents = new List<AuditAdminEvent>();
            this.AuditAssessorEvents = new List<AuditAssessorEvent>();
            this.AuditPersonEvents = new List<AuditPersonEvent>();
        }

        public byte AuditActionID { get; set; }
        public string ActionName { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditAdminEvent> AuditAdminEvents { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<AuditPersonEvent> AuditPersonEvents { get; set; }
    }
}
