using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Login
    {
        public int LoginID { get; set; }
        public Nullable<int> UserID { get; set; }
        public bool Success { get; set; }
        public string IP { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}
