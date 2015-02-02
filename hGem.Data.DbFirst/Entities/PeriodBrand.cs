using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PeriodBrand
    {
        public int PeriodBrandId { get; set; }
        public int PeriodId { get; set; }
        public int BrandId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Period Period { get; set; }
    }
}