using System;

namespace Warp.Data.Entities
{
    public class CommunicationPreference
    {
        public int CommunicationPreferencesId { get; set; }
        public int PersonId { get; set; }
        public int AssessorId { get; set; }
        public byte CommunicationTypeId { get; set; }
        public decimal? ScoreGreaterThanCondition { get; set; }
        public decimal? ScoreLessThanCondition { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual CommunicationType CommunicationType { get; set; }
    }
}