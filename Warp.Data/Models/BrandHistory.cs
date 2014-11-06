using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class BrandHistory
    {
        public int BrandHistoryID { get; set; }
        public int BrandID { get; set; }
        public int BrandStatusID { get; set; }
        public int EnteredByAdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public string Notes { get; set; }
        public System.DateTime Created { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual BrandStatu BrandStatu { get; set; }
    }
}
