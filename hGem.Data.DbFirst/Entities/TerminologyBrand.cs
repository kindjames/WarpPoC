using System;

namespace Warp.Data.DbFirst.Entities
{
    public class TerminologyBrand
    {
        public int TerminologyBrandId { get; set; }
        public short TerminologyId { get; set; }
        public int BrandId { get; set; }
        public string BrandTerm { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Terminology Terminology { get; set; }
    }
}