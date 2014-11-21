using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class StaffClothingColour
    {
        public StaffClothingColour()
        {
            StaffMemberClothingItems = new List<StaffMemberClothingItem>();
        }

        public byte StaffClothingColourId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
    }
}