using System;

namespace Warp.Data.DbFirst.Entities
{
    public class CriteriaConfig
    {
        public int CriteriaConfigId { get; set; }
        public int CriteriaSetId { get; set; }
        public short CriteriaOptionId { get; set; }
        public short CriteriaOperatorId { get; set; }
        public string Value { get; set; }
        public string SQL { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual CriteriaOperator CriteriaOperator { get; set; }
        public virtual CriteriaOption CriteriaOption { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
    }
}