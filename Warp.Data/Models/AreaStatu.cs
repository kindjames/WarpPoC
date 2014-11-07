using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaStatu
    {
        public AreaStatu()
        {
            this.Areas = new List<Area>();
            this.AreaHistories = new List<AreaHistory>();
        }

        public int AreaStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<AreaHistory> AreaHistories { get; set; }
    }
}
