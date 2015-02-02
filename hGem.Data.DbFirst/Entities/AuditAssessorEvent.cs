using System;

namespace Warp.Data.DbFirst.Entities
{
    public class AuditAssessorEvent
    {
        public int AuditAssessorEventId { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public int AssessorId { get; set; }
        public short AuditTableId { get; set; }
        public byte AuditActionId { get; set; }
        public string Id { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}