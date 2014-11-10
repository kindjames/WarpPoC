namespace Warp.Data.Entities
{
    public partial class AuditAssessorEvent
    {
        public int AuditAssessorEventID { get; set; }
        public System.DateTime DateTimeStamp { get; set; }
        public int AssessorID { get; set; }
        public short AuditTableID { get; set; }
        public byte AuditActionID { get; set; }
        public string ID { get; set; }
        public bool Hidden { get; set; }
        public string Note { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AuditAction AuditAction { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AuditTable AuditTable { get; set; }
    }
}
