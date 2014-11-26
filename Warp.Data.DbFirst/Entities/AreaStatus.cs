using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class AreaStatus
    {
        public AreaStatus()
        {
            Areas = new List<Area>();
            AreaHistories = new List<AreaHistory>();
        }

        public int AreaStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
    }
}