using System;

namespace Warp.Data.Entities
{
    public partial class PersonBrand
    {
        public int PersonBrandID { get; set; }
        public int PersonID { get; set; }
        public Nullable<int> PermissionTypeID { get; set; }
        public int BrandID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Person Person { get; set; }
        public virtual PersonBrand PersonBrand1 { get; set; }
        public virtual PersonBrand PersonBrand2 { get; set; }
    }
}
