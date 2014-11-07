using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class TerminologyClient
    {
        public int TerminiologyClientID { get; set; }
        public short TerminologyID { get; set; }
        public int ClientID { get; set; }
        public string ClientTerm { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Client Client { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}
