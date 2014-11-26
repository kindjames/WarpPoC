using System;

namespace Warp.Data.Entities
{
    public class Client : EntityBase
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public short ClientStatusId { get; set; }
        public string Code { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DateValidFrom { get; set; }
        public virtual ClientStatus ClientStatus { get; set; }
    }
}