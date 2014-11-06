using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitAction
    {
        public int VisitActionID { get; set; }
        public int VisitId { get; set; }
        public int ActionID { get; set; }
        public virtual Action Action { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
