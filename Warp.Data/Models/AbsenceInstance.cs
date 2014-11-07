using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AbsenceInstance
    {
        public int AbsenceInstanceID { get; set; }
        public byte AbsenceTypeID { get; set; }
        public int AdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public System.DateTime DateValidTo { get; set; }
        public int ApprovedByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AbsenceType AbsenceType { get; set; }
    }
}
