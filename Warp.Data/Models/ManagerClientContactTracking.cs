using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ManagerClientContactTracking
    {
        public int ManagerClientContactTrackingID { get; set; }
        public int ManagerID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
