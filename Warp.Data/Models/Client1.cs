using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Client1
    {
        public Client1()
        {
            this.Brand1 = new List<Brand1>();
            this.ManagerClients = new List<ManagerClient>();
        }

        public int ClientID { get; set; }
        public string Name { get; set; }
        public short ClientStatusID { get; set; }
        public Nullable<int> CapsuleID { get; set; }
        public short CurrencyID { get; set; }
        public int AccountManagerAdminID { get; set; }
        public short AssessorBanDays { get; set; }
        public Nullable<int> ClientContactManagerID { get; set; }
        public bool Visible { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Brand1> Brand1 { get; set; }
        public virtual ClientStatus1 ClientStatus1 { get; set; }
        public virtual ICollection<ManagerClient> ManagerClients { get; set; }
    }
}
