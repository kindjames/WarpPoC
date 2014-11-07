using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AdminClientContactTracking
    {
        public int AdminClientContactTrackingID { get; set; }
        public int AdminID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
