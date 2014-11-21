using System;

namespace Warp.Data.Entities
{
    public class BriefBrand
    {
        public int BriefBrand1 { get; set; }
        public int BrandId { get; set; }
        public int BriefId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Brief Brief { get; set; }
    }
}