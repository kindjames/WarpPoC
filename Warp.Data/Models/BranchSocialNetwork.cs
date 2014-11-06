using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BranchSocialNetwork
    {
        public int BranchSocialNetworkID { get; set; }
        public int SocialNetworkID { get; set; }
        public int BranchID { get; set; }
        public bool Active { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string Value { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}
