using System;

namespace Warp.Data.Entities
{
    public class Client : EntityBase
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public DateTime? DateValidFrom { get; set; }

        public ClientStatus ClientStatus { get; set; }
        public User AccountManager { get; set; }
        public Customer Customer { get; set; }
    }
}