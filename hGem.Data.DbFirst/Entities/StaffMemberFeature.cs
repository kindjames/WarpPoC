using System;

namespace Warp.Data.DbFirst.Entities
{
    public class StaffMemberFeature
    {
        public int StaffMemberFeatureId { get; set; }
        public int StaffMemberId { get; set; }
        public short StaffFeatureId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual StaffFeature StaffFeature { get; set; }
        public virtual StaffMember StaffMember { get; set; }
    }
}