using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorAttribute
    {
        public int AssessorAttributeID { get; set; }
        public int AssessorID { get; set; }
        public short AssessorAttributeItemID { get; set; }
        public short AssessorAttributeOptionID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
        public virtual AssessorAttributeOption AssessorAttributeOption { get; set; }
    }
}
