using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class AuditTable
    {
        public AuditTable()
        {
            this.AuditAdminEvents = new List<AuditAdminEvent>();
            this.AuditAssessorEvents = new List<AuditAssessorEvent>();
            this.AuditPersonEvents = new List<AuditPersonEvent>();
        }

        public short AuditTableID { get; set; }
        public string TableName { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditAdminEvent> AuditAdminEvents { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<AuditPersonEvent> AuditPersonEvents { get; set; }
    }
}
