using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class StaffHairLength
    {
        public StaffHairLength()
        {
            StaffMembers = new List<StaffMember>();
        }

        public byte StaffHairLengthId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}