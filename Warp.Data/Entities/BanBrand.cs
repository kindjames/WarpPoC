using System;

namespace Warp.Data.Entities
{
    public partial class BanBrand
    {
        public int BanBrandID { get; set; }
        public int BrandID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
