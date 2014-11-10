namespace Warp.Data.Entities
{
    public partial class BrandLegacyUser
    {
        public int BrandLegacyID { get; set; }
        public int BrandID { get; set; }
        public int LegacyID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
