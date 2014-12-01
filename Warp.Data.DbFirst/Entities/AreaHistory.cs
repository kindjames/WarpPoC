using System;

namespace Warp.Data.DbFirst.Entities
{
    public class AreaHistory
    {
        public int AreaHistoryId { get; set; }
        public int AreaId { get; set; }
        public string AreaName { get; set; }
        public int AreaStatusId { get; set; }
        public int RegionId { get; set; }
        public string Code { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int EnteredByUserRoleId { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Area Area { get; set; }
        public virtual Region Region { get; set; }
        public virtual AreaStatus AreaStatus { get; set; }
    }
}