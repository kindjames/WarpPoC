using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Event
    {
        public int LogEventID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public Nullable<int> ActionEventID { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ActionEvent ActionEvent { get; set; }
    }
}
