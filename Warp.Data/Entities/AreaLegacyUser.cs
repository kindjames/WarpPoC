using System;

namespace Warp.Data.Entities
{
    public class AreaLegacyUser
    {
        public int AreaLegacyId { get; set; }
        public int AreaId { get; set; }
        public int LegacyId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Area Area { get; set; }
    }
}