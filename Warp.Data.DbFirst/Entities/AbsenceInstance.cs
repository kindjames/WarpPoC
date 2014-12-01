using System;

namespace Warp.Data.DbFirst.Entities
{
    public class AbsenceInstance
    {
        public int AbsenceInstanceId { get; set; }
        public byte AbsenceTypeId { get; set; }
        public int AdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime DateValidTo { get; set; }
        public int ApprovedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AbsenceType AbsenceType { get; set; }
    }
}