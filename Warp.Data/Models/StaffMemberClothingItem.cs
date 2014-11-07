using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffMemberClothingItem
    {
        public int StaffMemberClothingItemID { get; set; }
        public int StaffMemberID { get; set; }
        public short StaffClothingItemID { get; set; }
        public byte StaffClothingColourID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual StaffClothingColour StaffClothingColour { get; set; }
        public virtual StaffClothingItem StaffClothingItem { get; set; }
        public virtual StaffMember StaffMember { get; set; }
    }
}
