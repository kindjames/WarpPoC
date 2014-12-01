using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class CodeResource
    {
        public CodeResource()
        {
            Translations = new List<Translation>();
        }

        public int CodeResourceId { get; set; }
        public int CodeResourceTypeId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual CodeResourceType CodeResourceType { get; set; }
        public virtual ICollection<Translation> Translations { get; set; }
    }
}