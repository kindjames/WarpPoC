using System;

namespace hGem.Core.Data
{
    public abstract class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}