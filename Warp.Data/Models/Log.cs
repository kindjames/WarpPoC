using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Log
    {
        public int LogID { get; set; }
        public string context { get; set; }
        public int context_id { get; set; }
        public string behaviour { get; set; }
        public int user_id { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}
