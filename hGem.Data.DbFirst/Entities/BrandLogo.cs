using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BrandLogo
    {
        public int BrandLogoId { get; set; }
        public int BrandId { get; set; }
        public int LogoId { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual Logo Logo { get; set; }
    }
}