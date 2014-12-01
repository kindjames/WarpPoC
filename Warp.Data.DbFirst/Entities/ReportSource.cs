using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ReportSource
    {
        public ReportSource()
        {
            Reports = new List<Report>();
        }

        public int ReportSourceId { get; set; }
        public string Name { get; set; }
        public string SSRSPath { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Report> Reports { get; set; }
    }
}