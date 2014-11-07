using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitAction
    {
        public int VisitActionID { get; set; }
        public int VisitId { get; set; }
        public int ActionID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual Action Action { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
