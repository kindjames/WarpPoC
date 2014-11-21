using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ReportSection
    {
        public ReportSection()
        {
            Reports = new List<Report>();
        }

        public int ReportSectionId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}