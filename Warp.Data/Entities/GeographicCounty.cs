using System;

namespace Warp.Data.Entities
{
    public class GeographicCounty
    {
        public int GeographicCountyId { get; set; }
        public int GeographicRegionId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual GeographicRegion GeographicRegion { get; set; }
    }
}