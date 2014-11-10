using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Period
    {
        public Period()
        {
            this.PeriodBrands = new List<PeriodBrand>();
            this.PeriodClients = new List<PeriodClient>();
            this.Visits = new List<Visit>();
        }

        public int PeriodID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateStart { get; set; }
        public Nullable<System.DateTime> DateEnd { get; set; }
        public bool ExcludeFromAnalysis { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PeriodBrand> PeriodBrands { get; set; }
        public virtual ICollection<PeriodClient> PeriodClients { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}
