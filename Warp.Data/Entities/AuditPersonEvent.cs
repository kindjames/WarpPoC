namespace Warp.Data.Entities
{
    public partial class AuditPersonEvent
    {
        public int AuditPersonEventID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public int PersonID { get; set; }
        public short AuditTableID { get; set; }
        public byte AuditActionID { get; set; }
        public string ID { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}
