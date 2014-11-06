using System;

namespace Warp.Data.Models
{
    public abstract class EntityBase
    {
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
    }
}