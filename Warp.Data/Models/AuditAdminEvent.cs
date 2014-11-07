using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AuditAdminEvent
    {
        public int AuditAdminiEventID { get; set; }
        public short AdminID { get; set; }
        public short AuditTableID { get; set; }
        public byte AuditActionID { get; set; }
        public string ID { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}
