namespace Warp.Data.Entities
{
    public partial class BrandLogo
    {
        public int BrandLogoID { get; set; }
        public int BrandID { get; set; }
        public int LogoID { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public System.DateTime Created { get; set; }
        public bool Active { get; set; }
        public virtual Logo Logo { get; set; }
    }
}
