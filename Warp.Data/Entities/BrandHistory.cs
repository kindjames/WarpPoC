using System;

namespace Warp.Data.Entities
{
    public class BrandHistory
    {
        public int BrandHistoryId { get; set; }
        public int BrandId { get; set; }
        public int BrandStatusId { get; set; }
        public int EnteredByUserRoleId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual BrandStatus BrandStatus { get; set; }
    }
}