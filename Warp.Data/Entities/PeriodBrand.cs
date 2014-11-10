namespace Warp.Data.Entities
{
    public partial class PeriodBrand
    {
        public int PeriodBrandID { get; set; }
        public int PeriodID { get; set; }
        public int BrandID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Period Period { get; set; }
    }
}
