using System;

namespace Warp.Data.Entities
{
    public class PersonCallBackRequest
    {
        public int PersonCallBackRequestId { get; set; }
        public int PersonId { get; set; }
        public int CallBackRequestId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual CallBackRequest CallBackRequest { get; set; }
    }
}