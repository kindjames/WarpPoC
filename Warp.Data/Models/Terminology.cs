using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Terminology
    {
        public Terminology()
        {
            this.TerminologyBrands = new List<TerminologyBrand>();
            this.TerminologyClients = new List<TerminologyClient>();
        }

        public short TerminologyID { get; set; }
        public string Term { get; set; }
        public System.DateTime DateAdded { get; set; }
        public short AddedByAdminID { get; set; }
        public System.DateTime DeactivatedDate { get; set; }
        public short DeactivatedByAdminID { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<TerminologyBrand> TerminologyBrands { get; set; }
        public virtual ICollection<TerminologyClient> TerminologyClients { get; set; }
    }
}
