using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchLogo
    {
        public int BranchLogoID { get; set; }
        public int BranchID { get; set; }
        public string LogoPath { get; set; }
    }
}
