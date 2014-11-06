using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonArea
    {
        public int PersonAreaID { get; set; }
        public int PersonID { get; set; }
        public int AreaID { get; set; }
        public virtual Area Area { get; set; }
    }
}
