using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class StaffClothingItem
    {
        public StaffClothingItem()
        {
            StaffMemberClothingItems = new List<StaffMemberClothingItem>();
        }

        public short StaffClothingItemId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public byte GenderId { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ICollection<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
    }
}