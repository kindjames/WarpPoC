using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BanClient
    {
        public int BanClientID { get; set; }
        public int ClientID { get; set; }
        public int AssessorID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Assessor Assessor { get; set; }
    }
}
