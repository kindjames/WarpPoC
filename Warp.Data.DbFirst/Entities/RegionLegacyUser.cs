using System;

namespace Warp.Data.DbFirst.Entities
{
    public class RegionLegacyUser
    {
        public int RegionLegacyId { get; set; }
        public int RegionId { get; set; }
        public int LegacyId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Region Region { get; set; }
    }
}