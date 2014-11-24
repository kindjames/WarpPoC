using System;

namespace Warp.Data.Entities
{
    public class AdminClientContactTracking
    {
        public int AdminClientContactTrackingId { get; set; }
        public int AdminId { get; set; }
        public int ClientContactTrackingId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}