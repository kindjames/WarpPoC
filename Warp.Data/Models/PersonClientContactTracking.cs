using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonClientContactTracking
    {
        public int PersonClientContactTrackingID { get; set; }
        public int PersonID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
