using System;

namespace Warp.Data.Entities
{
    public class ClientCallBackRequest
    {
        public int ClientCallBackRequestId { get; set; }
        public int ClientId { get; set; }
        public int CallBackRequestId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}