using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class StaffMember
    {
        public StaffMember()
        {
            StaffMemberClothingItems = new List<StaffMemberClothingItem>();
            StaffMemberFeatures = new List<StaffMemberFeature>();
        }

        public int StaffMemberId { get; set; }
        public int VisitId { get; set; }
        public DateTime DateCreated { get; set; }
        public int AssessorId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public byte StaffAgeId { get; set; }
        public byte StaffHeightId { get; set; }
        public byte StaffHairColourId { get; set; }
        public byte StaffHairLengthId { get; set; }
        public byte StaffHairStyleId { get; set; }
        public byte GenderId { get; set; }
        public int? CheckedByAdminId { get; set; }
        public bool Active { get; set; }
        public bool Approved { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual StaffAge StaffAge { get; set; }
        public virtual StaffHairColour StaffHairColour { get; set; }
        public virtual StaffHairLength StaffHairLength { get; set; }
        public virtual StaffHairStyle StaffHairStyle { get; set; }
        public virtual StaffHeight StaffHeight { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual ICollection<StaffMemberClothingItem> StaffMemberClothingItems { get; set; }
        public virtual ICollection<StaffMemberFeature> StaffMemberFeatures { get; set; }
    }
}