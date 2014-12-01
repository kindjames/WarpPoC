using System;

namespace Warp.Data.DbFirst.Entities
{
    public class VisitDetail
    {
        public int VisitDetailsId { get; set; }
        public int VisitId { get; set; }
        public DateTime DateOfActualVisit { get; set; }
        public short AdultGuests { get; set; }
        public short ChildGuests { get; set; }
        public short ChildGuestsNotInvolved { get; set; }
        public string ReceiptNumber { get; set; }
        public short TradeLevelId { get; set; }
        public int SeatingLevel { get; set; }
        public short WeatherId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual TradeLevel TradeLevel { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual Weather Weather { get; set; }
    }
}