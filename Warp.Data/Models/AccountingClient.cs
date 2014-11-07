using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AccountingClient
    {
        public AccountingClient()
        {
            this.AccountingInvoices = new List<AccountingInvoice>();
        }

        public int AccountingClientID { get; set; }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public int KashFlowID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<AccountingInvoice> AccountingInvoices { get; set; }
    }
}
