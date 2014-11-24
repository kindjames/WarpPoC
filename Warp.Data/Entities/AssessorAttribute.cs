using System;

namespace Warp.Data.Entities
{
    public class AssessorAttribute
    {
        public int AssessorAttributeId { get; set; }
        public int AssessorId { get; set; }
        public short AssessorAttributeItemId { get; set; }
        public short AssessorAttributeOptionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual AssessorAttributeItem AssessorAttributeItem { get; set; }
        public virtual AssessorAttributeOption AssessorAttributeOption { get; set; }
    }
}