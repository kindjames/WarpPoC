using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Brand1
    {
        public Brand1()
        {
            this.Branch1 = new List<Branch1>();
            this.BrandHistory1 = new List<BrandHistory1>();
            this.ContactAddressBrand1 = new List<ContactAddressBrand1>();
            this.ManagerBrands = new List<ManagerBrand>();
        }

        public int BrandID { get; set; }
        public string Name { get; set; }
        public int ClientID { get; set; }
        public short BrandStatusID { get; set; }
        public short IndustrySectorID { get; set; }
        public int AccountManagerAdminID { get; set; }
        public Nullable<short> AssessorBanDays { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Branch1> Branch1 { get; set; }
        public virtual BrandStatus1 BrandStatus1 { get; set; }
        public virtual Client1 Client1 { get; set; }
        public virtual ICollection<BrandHistory1> BrandHistory1 { get; set; }
        public virtual ICollection<ContactAddressBrand1> ContactAddressBrand1 { get; set; }
        public virtual ICollection<ManagerBrand> ManagerBrands { get; set; }
    }
}
