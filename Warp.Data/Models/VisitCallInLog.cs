using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitCallInLog
    {
        public int VisitCallInLogID { get; set; }
        public int VisitID { get; set; }
        public int CallInLogID { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual CallInLog CallInLog { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
