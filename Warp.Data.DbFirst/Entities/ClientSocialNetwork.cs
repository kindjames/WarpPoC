using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ClientSocialNetwork
    {
        public int ClientSocialNetworkId { get; set; }
        public int SocialNetworkId { get; set; }
        public int ClientId { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public string Value { get; set; }
        public virtual Client Client { get; set; }
        public virtual SocialNetwork SocialNetwork { get; set; }
    }
}