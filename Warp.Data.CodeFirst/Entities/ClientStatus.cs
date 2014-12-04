using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Warp.Data.Entities
{
    public class ClientStatus : EntityBase
    {
        public ClientStatus()
        {
            Clients = new Collection<Client>();
        }

        public short ClientStatusId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}