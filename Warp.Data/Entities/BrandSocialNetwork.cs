using System;

namespace Warp.Data.Entities
{
    public class BrandSocialNetwork
    {
        public int BrandSocialNetworkId { get; set; }
        public int SocialNetworkId { get; set; }
        public int BrandId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string Value { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}