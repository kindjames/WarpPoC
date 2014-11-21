using System;

namespace Warp.Data.Entities
{
    public class AssessorGeographicPostCode
    {
        public int AssessorGeographicPostCodeId { get; set; }
        public int AssessorId { get; set; }
        public int GeographicPostCodeId { get; set; }
        public int Radius { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}