using System;

namespace Warp.Data.Entities
{
    public class ClientCallInLog
    {
        public int ClientCallInLogId { get; set; }
        public int ClientId { get; set; }
        public int CallInLogId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual CallInLog CallInLog { get; set; }
    }
}