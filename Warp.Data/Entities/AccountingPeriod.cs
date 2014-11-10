using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class AccountingPeriod
    {
        public AccountingPeriod()
        {
            this.AccountingInvoices = new List<AccountingInvoice>();
            this.Visits = new List<Visit>();
        }

        public int AccountingPeriodID { get; set; }
        public string PeriodName { get; set; }
        public int ClientID { get; set; }
        public bool Active { get; set; }
        public short CreatedByAdminID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<AccountingInvoice> AccountingInvoices { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
