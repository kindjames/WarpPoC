using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class PersonClient
    {
        public int PersonClientID { get; set; }
        public int PersonID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
    }
}
