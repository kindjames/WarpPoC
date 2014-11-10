using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class StaffHairLength
    {
        public StaffHairLength()
        {
            this.StaffMembers = new List<StaffMember>();
        }

        public byte StaffHairLengthID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
