using System;

namespace Warp.Data.Entities
{
    public class BranchHistory : EntityBase
    {
        public int BranchHistoryId { get; set; }
        public int BranchId { get; set; }
        public int BranchStatusId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public int AreaId { get; set; }
        public string Notes { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int EnteredByUserRoleId { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual BranchStatus BranchStatus { get; set; }
    }
}
