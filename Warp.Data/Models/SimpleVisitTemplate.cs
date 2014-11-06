using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class SimpleVisitTemplate
    {
        public SimpleVisitTemplate()
        {
            this.SimpleVisits = new List<SimpleVisit>();
        }

        public int SimpleVisitTemplateID { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public int QuestionnaireID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public Nullable<int> RequiredCount { get; set; }
        public Nullable<System.DateTime> CountReached { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
        public virtual ICollection<SimpleVisit> SimpleVisits { get; set; }
    }
}
