using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class StaffHairStyle
    {
        public StaffHairStyle()
        {
            StaffMembers = new List<StaffMember>();
        }

        public byte StaffHairStyleId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}