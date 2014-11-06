using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonCallBackRequest
    {
        public int PersonCallBackRequestID { get; set; }
        public int PersonID { get; set; }
        public int CallBackRequestID { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}
