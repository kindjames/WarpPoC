using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessmentArea : EntityBase
    {
        public AssessmentArea()
        {
            this.AccountingTransactions = new List<AccountingTransaction>();
            this.Assessments = new List<Assessment>();
            this.AssessmentAreaBranches = new List<AssessmentAreaBranch>();
        }

        public short AssessmentAreaId { get; set; }
        public string Name { get; set; }
        public short AssessmentTypeId { get; set; }
        public virtual ICollection<AccountingTransaction> AccountingTransactions { get; set; }
        public virtual ICollection<Assessment> Assessments { get; set; }
        public virtual AssessmentType AssessmentType { get; set; }
        public virtual ICollection<AssessmentAreaBranch> AssessmentAreaBranches { get; set; }
    }
}
