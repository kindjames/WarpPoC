using System;

namespace Warp.Data.DbFirst.Entities
{
    public class ClientLogo
    {
        public int ClientLogoId { get; set; }
        public int ClientId { get; set; }
        public int LogoId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Logo Logo { get; set; }
    }
}