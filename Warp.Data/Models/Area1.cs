using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Area1
    {
        public Area1()
        {
            this.AreaHistory1 = new List<AreaHistory1>();
            this.Branch1 = new List<Branch1>();
            this.ManagerAreas = new List<ManagerArea>();
            this.Region1 = new List<Region1>();
        }

        public int AreaID { get; set; }
        public string Name { get; set; }
        public short AreaStatusID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public virtual AreaStatus1 AreaStatus1 { get; set; }
        public virtual ICollection<AreaHistory1> AreaHistory1 { get; set; }
        public virtual ICollection<Branch1> Branch1 { get; set; }
        public virtual ICollection<ManagerArea> ManagerAreas { get; set; }
        public virtual ICollection<Region1> Region1 { get; set; }
    }
}
