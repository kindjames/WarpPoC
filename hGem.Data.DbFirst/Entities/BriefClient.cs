using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BriefClient
    {
        public int BriefClientId { get; set; }
        public int ClientId { get; set; }
        public int BriefId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Brief Brief { get; set; }
    }
}