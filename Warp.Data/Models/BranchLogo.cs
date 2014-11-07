using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchLogo
    {
        public int BranchLogoID { get; set; }
        public int BranchID { get; set; }
        public int LogoID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Logo Logo { get; set; }
    }
}
