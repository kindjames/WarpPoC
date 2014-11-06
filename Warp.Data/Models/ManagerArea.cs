using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerArea
    {
        public int ManagerAreaID { get; set; }
        public int ManagerID { get; set; }
        public int AreaID { get; set; }
        public virtual Area1 Area1 { get; set; }
    }
}
