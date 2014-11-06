using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerCallBackRequest
    {
        public int ManagerCallBackRequestID { get; set; }
        public int ManagerID { get; set; }
        public int CallBackRequestID { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}
