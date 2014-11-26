using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ClientStatus : EntityBase
    {
        public ClientStatus()
        {
            this.Clients = new List<Client>();
        }

        public short ClientStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}