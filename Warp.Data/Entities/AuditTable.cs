using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AuditTable
    {
        public AuditTable()
        {
            AuditAdminEvents = new List<AuditAdminEvent>();
            AuditAssessorEvents = new List<AuditAssessorEvent>();
            AuditPersonEvents = new List<AuditPersonEvent>();
        }

        public short AuditTableId { get; set; }
        public string TableName { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AuditAdminEvent> AuditAdminEvents { get; set; }
        public virtual ICollection<AuditAssessorEvent> AuditAssessorEvents { get; set; }
        public virtual ICollection<AuditPersonEvent> AuditPersonEvents { get; set; }
    }
}