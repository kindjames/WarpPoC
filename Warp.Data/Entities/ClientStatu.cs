using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ClientStatu
    {
        public ClientStatu()
        {
            this.Clients = new List<Client>();
            this.ClientHistories = new List<ClientHistory>();
        }

        public short ClientStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ClientHistory> ClientHistories { get; set; }
    }
}
