using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BranchSocialNetwork
    {
        public int BranchSocialNetworkId { get; set; }
        public int SocialNetworkId { get; set; }
        public int BranchId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Value { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}