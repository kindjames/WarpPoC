using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Branch1
    {
        public Branch1()
        {
            this.BranchHistory1 = new List<BranchHistory1>();
            this.ContactAddressBranch1 = new List<ContactAddressBranch1>();
            this.ManagerBranches = new List<ManagerBranch>();
        }

        public int BranchID { get; set; }
        public string Name { get; set; }
        public int BrandID { get; set; }
        public int AccountingClientID { get; set; }
        public int AreaID { get; set; }
        public short BranchStatusID { get; set; }
        public short CurrencyID { get; set; }
        public int AccountManagerAdminID { get; set; }
        public Nullable<short> AssessorBanDays { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public string AssessorDisplayName { get; set; }
        public bool MobileApp { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
        public virtual AccountingClient AccountingClient { get; set; }
        public virtual Area1 Area1 { get; set; }
        public virtual BranchStatus1 BranchStatus1 { get; set; }
        public virtual Brand1 Brand1 { get; set; }
        public virtual ICollection<BranchHistory1> BranchHistory1 { get; set; }
        public virtual ICollection<ContactAddressBranch1> ContactAddressBranch1 { get; set; }
        public virtual ICollection<ManagerBranch> ManagerBranches { get; set; }
    }
}
