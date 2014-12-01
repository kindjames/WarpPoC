using System;

namespace Warp.Data.DbFirst.Entities
{
    public class StaffMemberClothingItem
    {
        public int StaffMemberClothingItemId { get; set; }
        public int StaffMemberId { get; set; }
        public short StaffClothingItemId { get; set; }
        public byte StaffClothingColourId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual StaffClothingColour StaffClothingColour { get; set; }
        public virtual StaffClothingItem StaffClothingItem { get; set; }
        public virtual StaffMember StaffMember { get; set; }
    }
}