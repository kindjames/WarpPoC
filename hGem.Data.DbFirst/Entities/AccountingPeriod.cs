using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class AccountingPeriod
    {
        public AccountingPeriod()
        {
            AccountingInvoices = new List<AccountingInvoice>();
            Visits = new List<Visit>();
        }

        public int AccountingPeriodId { get; set; }
        public string PeriodName { get; set; }
        public int ClientId { get; set; }
        public bool Active { get; set; }
        public short CreatedByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<AccountingInvoice> AccountingInvoices { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}