using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BanBranch : EntityBase
    {
        public int BanBranchId { get; set; }
        public int BranchId { get; set; }
        public int AssessorId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}