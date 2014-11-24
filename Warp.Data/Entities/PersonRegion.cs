using System;

namespace Warp.Data.Entities
{
    public class PersonRegion
    {
        public int PersonRegionId { get; set; }
        public int PersonId { get; set; }
        public int RegionId { get; set; }
        public int? PermissionTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
        public virtual Region Region { get; set; }
    }
}