using System;

namespace Warp.Data.Entities
{
    public class PersonClientContactTracking
    {
        public int PersonClientContactTrackingId { get; set; }
        public int PersonId { get; set; }
        public int ClientContactTrackingId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ClientContactTracking ClientContactTracking { get; set; }
    }
}