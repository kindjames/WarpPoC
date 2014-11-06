using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Login
    {
        public int LoginID { get; set; }
        public Nullable<int> UserID { get; set; }
        public System.DateTime Timestamp { get; set; }
        public bool Success { get; set; }
        public string IP { get; set; }
    }
}
