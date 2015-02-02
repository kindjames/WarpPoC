using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PersonBrand
    {
        public int PersonBrandId { get; set; }
        public int PersonId { get; set; }
        public int? PermissionTypeId { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Person Person { get; set; }
        public virtual PersonBrand PersonBrand1 { get; set; }
        public virtual PersonBrand PersonBrand2 { get; set; }
    }
}