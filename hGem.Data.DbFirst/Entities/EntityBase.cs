using System;

namespace Warp.Data.DbFirst.Entities
{
    public abstract class EntityBase
    {
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
    }
}