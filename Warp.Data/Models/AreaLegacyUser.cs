using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaLegacyUser
    {
        public int AreaLegacyID { get; set; }
        public int AreaID { get; set; }
        public int LegacyID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Area Area { get; set; }
    }
}
