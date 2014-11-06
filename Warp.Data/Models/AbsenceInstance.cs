using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AbsenceInstance
    {
        public int AbsenceInstanceID { get; set; }
        public byte AbsenceTypeID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AdminID { get; set; }
        public System.DateTime ValidFromDate { get; set; }
        public System.DateTime ValidToDate { get; set; }
        public int ApprovedByAdminID { get; set; }
        public virtual AbsenceType AbsenceType { get; set; }
    }
}
