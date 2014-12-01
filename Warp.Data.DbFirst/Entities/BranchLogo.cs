using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BranchLogo
    {
        public int BranchLogoId { get; set; }
        public int BranchId { get; set; }
        public int LogoId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Logo Logo { get; set; }
    }
}