using System;

namespace Warp.Data.Entities
{
    public class RegionHistory
    {
        public int RegionHistoryId { get; set; }
        public int RegionId { get; set; }
        public string RegionName { get; set; }
        public int RegionStatusId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int EnteredByUserRoleId { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public string Code { get; set; }
        public virtual Region Region { get; set; }
        public virtual RegionStatu RegionStatu { get; set; }
    }
}