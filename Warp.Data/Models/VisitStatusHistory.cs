using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitStatusHistory
    {
        public int VisitStatusHistoryID { get; set; }
        public int VisitID { get; set; }
        public short VisitStatusID { get; set; }
        public short AdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual VisitStatu VisitStatu { get; set; }
        public virtual VisitStatu VisitStatu1 { get; set; }
    }
}
