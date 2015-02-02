using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BanBrand
    {
        public int BanBrandId { get; set; }
        public int BrandId { get; set; }
        public int AssessorId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}