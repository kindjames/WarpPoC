using System;

namespace Warp.Data.DbFirst.Entities
{
    public class MenuConfigBranch
    {
        public int MenuConfigBranchId { get; set; }
        public int MenuConfigId { get; set; }
        public int BranchId { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool? Permission { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}