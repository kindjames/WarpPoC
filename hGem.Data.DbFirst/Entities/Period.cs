using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Period
    {
        public Period()
        {
            PeriodBrands = new List<PeriodBrand>();
            PeriodClients = new List<PeriodClient>();
            Visits = new List<Visit>();
        }

        public int PeriodId { get; set; }
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public bool ExcludeFromAnalysis { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<PeriodBrand> PeriodBrands { get; set; }
        public virtual ICollection<PeriodClient> PeriodClients { get; set; }
        public virtual ICollection<Visit> Visits { get; set; }
    }
}