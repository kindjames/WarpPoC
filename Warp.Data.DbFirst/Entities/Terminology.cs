using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Terminology
    {
        public Terminology()
        {
            TerminologyBrands = new List<TerminologyBrand>();
            TerminologyClients = new List<TerminologyClient>();
        }

        public short TerminologyId { get; set; }
        public string Term { get; set; }
        public DateTime DateCreated { get; set; }
        public short AddedByAdminId { get; set; }
        public DateTime DateDeactivated { get; set; }
        public short DeactivatedByAdminId { get; set; }
        public bool Active { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<TerminologyBrand> TerminologyBrands { get; set; }
        public virtual ICollection<TerminologyClient> TerminologyClients { get; set; }
    }
}