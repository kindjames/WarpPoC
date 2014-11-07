using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffHairColour
    {
        public StaffHairColour()
        {
            this.StaffMembers = new List<StaffMember>();
        }

        public byte StaffHairColourID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
