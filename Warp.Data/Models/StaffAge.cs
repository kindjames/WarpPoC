using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffAge
    {
        public StaffAge()
        {
            this.StaffMembers = new List<StaffMember>();
        }

        public byte StaffAgeID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
