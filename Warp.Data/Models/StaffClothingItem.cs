using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffClothingItem
    {
        public StaffClothingItem()
        {
            this.StaffMemberClothingItems = new List<StaffMemberClothingItem>();
        }

        public short StaffClothingItemID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public byte GenderID { get; set; }
        public string ImagePath { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
    }
}
