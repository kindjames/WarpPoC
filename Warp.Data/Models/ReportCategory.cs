using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ReportCategory
    {
        public ReportCategory()
        {
            this.Reports = new List<Report>();
        }

        public int ReportCategoryId { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
