using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientCallInLog
    {
        public int ClientCallInLogID { get; set; }
        public int ClientID { get; set; }
        public int CallInLogID { get; set; }
        public virtual Client Client { get; set; }
        public virtual CallInLog CallInLog { get; set; }
    }
}
