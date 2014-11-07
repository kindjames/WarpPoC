using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class StaffFeature
    {
        public StaffFeature()
        {
            this.StaffMemberFeatures = new List<StaffMemberFeature>();
        }

        public short StaffFeatureID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMemberFeature> StaffMemberFeatures { get; set; }
    }
}
