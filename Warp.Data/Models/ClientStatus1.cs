using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ClientStatus1
    {
        public ClientStatus1()
        {
            this.Client1 = new List<Client1>();
        }

        public short ClientStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Client1> Client1 { get; set; }
    }
}
