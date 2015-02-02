using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ClientStatus : EntityBase
    {
        public ClientStatus()
        {
            Clients = new List<Client>();
            ClientHistories = new List<ClientHistory>();
        }

        public short ClientStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<ClientHistory> ClientHistories { get; set; }
    }
}