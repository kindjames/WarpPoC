using System;

namespace Warp.Data.DbFirst.Entities
{
    public class BriefConfigurationBrand
    {
        public int BriefConfigurationBrand1 { get; set; }
        public int BriefConfigurationId { get; set; }
        public int BrandId { get; set; }
        public bool Permission { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual BriefConfiguration BriefConfiguration { get; set; }
    }
}