using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class SocialNetwork
    {
        public SocialNetwork()
        {
            BranchSocialNetworks = new List<BranchSocialNetwork>();
            BrandSocialNetworks = new List<BrandSocialNetwork>();
            ClientSocialNetworks = new List<ClientSocialNetwork>();
        }

        public int SocialNetworkId { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<BranchSocialNetwork> BranchSocialNetworks { get; set; }
        public virtual ICollection<BrandSocialNetwork> BrandSocialNetworks { get; set; }
        public virtual ICollection<ClientSocialNetwork> ClientSocialNetworks { get; set; }
    }
}