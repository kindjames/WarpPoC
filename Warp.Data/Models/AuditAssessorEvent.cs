using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AuditAssessorEvent
    {
        public int AuditAssessorEventID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public int AssessorID { get; set; }
        public short AuditTableID { get; set; }
        public byte AuditActionID { get; set; }
        public string ID { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}
