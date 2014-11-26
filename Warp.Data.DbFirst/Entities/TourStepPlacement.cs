using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class TourStepPlacement
    {
        public TourStepPlacement()
        {
            TourSteps = new List<TourStep>();
        }

        public int TourStepPlacementId { get; set; }
        public string Placement { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual ICollection<TourStep> TourSteps { get; set; }
    }
}