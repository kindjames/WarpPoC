using System;

namespace Warp.Data.Entities
{
    public class CCTFurtherNote
    {
        public int CCTFurtherNotesId { get; set; }
        public int ClientContactTrackingId { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}