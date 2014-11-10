using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class TourStep
    {
        public TourStep()
        {
            this.TourUserRoleTourSteps = new List<TourUserRoleTourStep>();
        }

        public int TourStepID { get; set; }
        public int TourID { get; set; }
        public string ElementID { get; set; }
        public int StepNumber { get; set; }
        public string StepTitle { get; set; }
        public string StepText { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public System.DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public Nullable<int> TourStepPlacementId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual TourStepPlacement TourStepPlacement { get; set; }
        public virtual ICollection<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
    }
}
