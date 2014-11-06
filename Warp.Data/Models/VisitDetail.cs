using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitDetail
    {
        public int VisitDetailsID { get; set; }
        public int VisitID { get; set; }
        public System.DateTime ActualVisitDate { get; set; }
        public short AdultGuests { get; set; }
        public short ChildGuests { get; set; }
        public short ChildGuestsNotInvolved { get; set; }
        public string ReceiptNumber { get; set; }
        public short TradeLevelID { get; set; }
        public int SeatingLevel { get; set; }
        public short WeatherID { get; set; }
        public virtual TradeLevel TradeLevel { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Weather Weather { get; set; }
    }
}
