using System;

namespace Warp.Data.DbFirst.Entities
{
    public class DynamicText
    {
        public int DynamicTextId { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? Active { get; set; }
    }
}