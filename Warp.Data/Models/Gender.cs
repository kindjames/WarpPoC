using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Gender
    {
        public Gender()
        {
            this.StaffClothingItems = new List<StaffClothingItem>();
            this.StaffMembers = new List<StaffMember>();
        }

        public byte GenderID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<StaffClothingItem> StaffClothingItems { get; set; }
        public virtual ICollection<StaffMember> StaffMembers { get; set; }
    }
}
