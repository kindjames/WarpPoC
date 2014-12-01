using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BranchLegacyUser
    {
        public int BranchLegacyId { get; set; }
        public int BranchId { get; set; }
        public int LegacyId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Branch Branch { get; set; }
    }
}