using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffMember
    {
        public StaffMember()
        {
            this.StaffMemberClothingItems = new List<StaffMemberClothingItem>();
            this.StaffMemberFeatures = new List<StaffMemberFeature>();
        }

        public int StaffMemberID { get; set; }
        public int VisitID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AssessorID { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public byte StaffAgeID { get; set; }
        public byte StaffHeightID { get; set; }
        public byte StaffHairColourID { get; set; }
        public byte StaffHairLengthID { get; set; }
        public byte StaffHairStyleID { get; set; }
        public byte GenderID { get; set; }
        public Nullable<int> CheckedByAdminID { get; set; }
        public bool Active { get; set; }
        public bool Approved { get; set; }
        public System.DateTime LastUpdated { get; set; }
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
