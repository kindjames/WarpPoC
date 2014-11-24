using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class TradeLevel
    {
        public TradeLevel()
        {
            VisitDetails = new List<VisitDetail>();
        }

        public short TradeLevelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<VisitDetail> VisitDetails { get; set; }
    }
}