using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ActionCategory
    {
        public ActionCategory()
        {
            this.ActionEvents = new List<ActionEvent>();
        }

        public int ActionCategoryID { get; set; }
        public string Category { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<ActionEvent> ActionEvents { get; set; }
    }
}
