using System;

namespace Warp.Data.Entities
{
    public partial class PersonRegion
    {
        public int PersonRegionID { get; set; }
        public int PersonID { get; set; }
        public int RegionID { get; set; }
        public Nullable<int> PermissionTypeID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual PermissionType PermissionType { get; set; }
        public virtual Person Person { get; set; }
        public virtual Region Region { get; set; }
    }
}
