using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffHairStyle
    {
        public StaffHairStyle()
        {
            this.StaffMembers = new List<StaffMember>();
        }

        public byte StaffHairStyleID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
