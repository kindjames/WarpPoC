using System;

namespace Warp.Data.Entities
{
    public class MenuConfigBrand
    {
        public int MenuConfigBrandId { get; set; }
        public int MenuConfigId { get; set; }
        public int BrandId { get; set; }
        public short AddedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool Permission { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}