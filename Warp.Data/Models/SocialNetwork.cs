using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SocialNetwork
    {
        public SocialNetwork()
        {
            this.BranchSocialNetworks = new List<BranchSocialNetwork>();
            this.BrandSocialNetworks = new List<BrandSocialNetwork>();
            this.ClientSocialNetworks = new List<ClientSocialNetwork>();
        }

        public int SocialNetworkID { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BranchSocialNetwork> BranchSocialNetworks { get; set; }
        public virtual ICollection<BrandSocialNetwork> BrandSocialNetworks { get; set; }
        public virtual ICollection<ClientSocialNetwork> ClientSocialNetworks { get; set; }
    }
}
