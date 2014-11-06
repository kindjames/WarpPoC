using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CCTFurtherNote
    {
        public int CCTFurtherNotesID { get; set; }
        public int ClientContactTrackingID { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}
