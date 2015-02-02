using System;

namespace Warp.Data.DbFirst.Entities
{
    public class PeriodClient
    {
        public int PeriodClientId { get; set; }
        public int PeriodId { get; set; }
        public int ClientId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Period Period { get; set; }
    }
}