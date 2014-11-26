using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Weather
    {
        public Weather()
        {
            VisitDetails = new List<VisitDetail>();
        }

        public short WeatherId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VisitDetail> VisitDetails { get; set; }
    }
}