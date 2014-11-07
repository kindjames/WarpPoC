using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandSocialNetwork
    {
        public int BrandSocialNetworkID { get; set; }
        public int SocialNetworkID { get; set; }
        public int BrandID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public string Value { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}
