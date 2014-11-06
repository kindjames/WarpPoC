using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AccountingClient
    {
        public AccountingClient()
        {
            this.AccountingInvoices = new List<AccountingInvoice>();
            this.Branch1 = new List<Branch1>();
        }

        public int AccountingClientID { get; set; }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public int KashFlowID { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<AccountingInvoice> AccountingInvoices { get; set; }
        public virtual ICollection<Branch1> Branch1 { get; set; }
    }
}
