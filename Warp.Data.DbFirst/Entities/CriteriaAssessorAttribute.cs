using System;

namespace Warp.Data.DbFirst.Entities
{
    public class CriteriaAssessorAttribute
    {
        public int CriteriaAssessorAttributeId { get; set; }
        public int CriteriaSetId { get; set; }
        public short AssessorAttributeItemId { get; set; }
        public string AssessorAttributeOptionIDs { get; set; }
        public string SQL { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
        public virtual CriteriaSet CriteriaSet { get; set; }
    }
}