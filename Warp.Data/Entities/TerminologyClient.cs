using System;

namespace Warp.Data.Entities
{
    public class TerminologyClient
    {
        public int TerminiologyClientId { get; set; }
        public short TerminologyId { get; set; }
        public int ClientId { get; set; }
        public string ClientTerm { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}