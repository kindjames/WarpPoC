using System;

namespace Warp.Data.Entities
{
    public class AuditPersonEvent
    {
        public int AuditPersonEventId { get; set; }
        public DateTime DateUpdated { get; set; }
        public int PersonId { get; set; }
        public short AuditTableId { get; set; }
        public byte AuditActionId { get; set; }
        public string Id { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}