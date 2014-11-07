using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffMemberFeature
    {
        public int StaffMemberFeatureID { get; set; }
        public int StaffMemberID { get; set; }
        public short StaffFeatureID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual StaffFeature StaffFeature { get; set; }
        public virtual StaffMember StaffMember { get; set; }
    }
}
