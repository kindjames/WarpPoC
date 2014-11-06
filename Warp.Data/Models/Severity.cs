using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Severity
    {
        public Severity()
        {
            this.ActionEvents = new List<ActionEvent>();
        }

        public int SeverityID { get; set; }
        public string Severity1 { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
        public Nullable<bool> Active { get; set; }
        public virtual ICollection<ActionEvent> ActionEvents { get; set; }
    }
}
