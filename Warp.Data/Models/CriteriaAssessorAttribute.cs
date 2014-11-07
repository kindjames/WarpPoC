using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CriteriaAssessorAttribute
    {
        public int CriteriaAssessorAttributeID { get; set; }
        public int CriteriaSetID { get; set; }
        public short AssessorAttributeItemID { get; set; }
        public string AssessorAttributeOptionIDs { get; set; }
        public string SQL { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
    }
}
