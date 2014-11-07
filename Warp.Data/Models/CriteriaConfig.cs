using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CriteriaConfig
    {
        public int CriteriaConfigID { get; set; }
        public int CriteriaSetID { get; set; }
        public short CriteriaOptionID { get; set; }
        public short CriteriaOperatorID { get; set; }
        public string Value { get; set; }
        public string SQL { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual CriteriaOperator CriteriaOperator { get; set; }
        public virtual CriteriaOption CriteriaOption { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
    }
}
