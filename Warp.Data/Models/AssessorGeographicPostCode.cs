using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorGeographicPostCode
    {
        public int AssessorGeographicPostCodeID { get; set; }
        public int AssessorID { get; set; }
        public int GeographicPostCodeID { get; set; }
        public int Radius { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual GeographicPostCode GeographicPostCode { get; set; }
    }
}
