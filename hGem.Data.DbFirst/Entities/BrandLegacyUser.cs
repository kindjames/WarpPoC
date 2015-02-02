using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BrandLegacyUser
    {
        public int BrandLegacyId { get; set; }
        public int BrandId { get; set; }
        public int LegacyId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
    }
}