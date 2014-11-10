using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class ReportSource
    {
        public ReportSource()
        {
            this.Reports = new List<Report>();
        }

        public int ReportSourceId { get; set; }
        public string Name { get; set; }
        public string SSRSPath { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}
