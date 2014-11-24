using System;

namespace Warp.Data.Entities
{
    public class MenuConfigClient
    {
        public int MenuConfigClientId { get; set; }
        public int MenuConfigId { get; set; }
        public int ClientId { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public bool Permission { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual MenuConfig MenuConfig { get; set; }
    }
}