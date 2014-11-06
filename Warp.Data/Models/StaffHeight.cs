using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffHeight
    {
        public StaffHeight()
        {
            this.StaffMembers = new List<StaffMember>();
        }

        public byte StaffHeightID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
