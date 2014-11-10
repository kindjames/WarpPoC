using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class SimpleVisitTemplate
    {
        public SimpleVisitTemplate()
        {
            this.SimpleVisits = new List<SimpleVisit>();
        }

        public int SimpleVisitTemplateID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public int AddedByAdminID { get; set; }
        public int QuestionnaireID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public Nullable<int> RequiredCount { get; set; }
        public Nullable<System.DateTime> DateCountReached { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
    }
}
