using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Location
    {
        public Location()
        {
            this.Branches = new List<Branch>();
        }

        public int LocationID { get; set; }
        public string Name { get; set; }
        public int LocationStatusID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual LocationStatu LocationStatu { get; set; }
    }
}
