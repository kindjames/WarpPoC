using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffClothingColour
    {
        public StaffClothingColour()
        {
            this.StaffMemberClothingItems = new List<StaffMemberClothingItem>();
        }

        public byte StaffClothingColourID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
    }
}
