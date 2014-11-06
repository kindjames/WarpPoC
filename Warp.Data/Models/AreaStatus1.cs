using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AreaStatus1
    {
        public AreaStatus1()
        {
            this.Area1 = new List<Area1>();
            this.AreaHistory1 = new List<AreaHistory1>();
        }

        public short AreaStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Area1> Area1 { get; set; }
        public virtual ICollection<AreaHistory1> AreaHistory1 { get; set; }
    }
}
