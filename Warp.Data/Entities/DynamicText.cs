using System;

namespace Warp.Data.Entities
{
    public partial class DynamicText
    {
        public int DynamicTextId { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<bool> Active { get; set; }
    }
}
