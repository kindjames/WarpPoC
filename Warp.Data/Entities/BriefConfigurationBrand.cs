namespace Warp.Data.Entities
{
    public partial class BriefConfigurationBrand
    {
        public int BriefConfigurationBrand1 { get; set; }
        public int BriefConfigurationID { get; set; }
        public int BrandID { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}
