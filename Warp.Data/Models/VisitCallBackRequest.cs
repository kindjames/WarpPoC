using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitCallBackRequest
    {
        public int VisitCallBackRequestID { get; set; }
        public int VisitID { get; set; }
        public int CallBackRequestID { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
