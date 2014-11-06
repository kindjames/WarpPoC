using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientContactStatus1
    {
        public short ClientContactStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
    }
}
