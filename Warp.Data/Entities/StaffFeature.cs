using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class StaffFeature
    {
        public StaffFeature()
        {
            StaffMemberFeatures = new List<StaffMemberFeature>();
        }

        public short StaffFeatureId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<StaffMemberFeature> StaffMemberFeatures { get; set; }
    }
}