using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientSocialNetwork
    {
        public int ClientSocialNetworkID { get; set; }
        public int SocialNetworkID { get; set; }
        public int ClientID { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Value { get; set; }
        public virtual Client Client { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}
