using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Logo
    {
        public Logo()
        {
            BranchLogoes = new List<BranchLogo>();
            BrandLogoes = new List<BrandLogo>();
            ClientLogoes = new List<ClientLogo>();
        }

        public int LogoId { get; set; }
        public int ClientId { get; set; }
        public string LogoPath { get; set; }
        public string OriginalFileName { get; set; }
        public DateTime LastUpdated { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BranchLogo> BranchLogoes { get; set; }
        public virtual ICollection<BrandLogo> BrandLogoes { get; set; }
        public virtual ICollection<ClientLogo> ClientLogoes { get; set; }
    }
}