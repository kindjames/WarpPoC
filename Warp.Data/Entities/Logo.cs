using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Logo
    {
        public Logo()
        {
            this.BranchLogoes = new List<BranchLogo>();
            this.BrandLogoes = new List<BrandLogo>();
            this.ClientLogoes = new List<ClientLogo>();
        }

        public int LogoID { get; set; }
        public int ClientID { get; set; }
        public string LogoPath { get; set; }
        public string OriginalFileName { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<BranchLogo> BranchLogoes { get; set; }
        public virtual ICollection<BrandLogo> BrandLogoes { get; set; }
        public virtual ICollection<ClientLogo> ClientLogoes { get; set; }
    }
}
