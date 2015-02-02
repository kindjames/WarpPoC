using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class AccountingClient
    {
        public AccountingClient()
        {
            AccountingInvoices = new List<AccountingInvoice>();
        }

        public int AccountingClientId { get; set; }
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int KashFlowId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual ICollection<AccountingInvoice> AccountingInvoices { get; set; }
    }
}