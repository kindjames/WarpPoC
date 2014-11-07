using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class CommunicationPreference
    {
        public int CommunicationPreferencesID { get; set; }
        public int PersonID { get; set; }
        public int AssessorID { get; set; }
        public byte CommunicationTypeID { get; set; }
        public Nullable<decimal> ScoreGreaterThanCondition { get; set; }
        public Nullable<decimal> ScoreLessThanCondition { get; set; }
        public string Notes { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}
