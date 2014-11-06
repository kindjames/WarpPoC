using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientCallBackRequest
    {
        public int ClientCallBackRequestID { get; set; }
        public int ClientID { get; set; }
        public int CallBackRequestID { get; set; }
        public virtual Client Client { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}
