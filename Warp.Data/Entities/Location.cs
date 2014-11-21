using System;

namespace Warp.Data.Entities
{
    public class Location
    {
        public int LocationId { get; set; }
        public string Name { get; set; }
        public int LocationStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual LocationStatu LocationStatu { get; set; }
    }
}