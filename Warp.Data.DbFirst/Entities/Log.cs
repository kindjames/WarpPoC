using System;

namespace Warp.Data.DbFirst.Entities
{
    public class Log
    {
        public int LogId { get; set; }
        public string context { get; set; }
        public int context_Id { get; set; }
        public string behaviour { get; set; }
        public int user_Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
    }
}