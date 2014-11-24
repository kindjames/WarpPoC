using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class TourStep
    {
        public TourStep()
        {
            TourUserRoleTourSteps = new List<TourUserRoleTourStep>();
        }

        public int TourStepId { get; set; }
        public int TourId { get; set; }
        public string ElementId { get; set; }
        public int StepNumber { get; set; }
        public string StepTitle { get; set; }
        public string StepText { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public int? TourStepPlacementId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual TourStepPlacement TourStepPlacement { get; set; }
        public virtual ICollection<TourUserRoleTourStep> TourUserRoleTourSteps { get; set; }
    }
}