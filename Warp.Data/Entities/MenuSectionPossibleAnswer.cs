using System;

namespace Warp.Data.Entities
{
    public class MenuSectionPossibleAnswer
    {
        public int MenuSectionPossibleAnswerId { get; set; }
        public int MenuSectionId { get; set; }
        public int PossibleAnswerId { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual MenuSection MenuSection { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}