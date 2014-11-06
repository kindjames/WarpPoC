using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuSectionPossibleAnswer
    {
        public int MenuSectionPossibleAnswerID { get; set; }
        public int MenuSectionID { get; set; }
        public int PossibleAnswerID { get; set; }
        public bool Active { get; set; }
        public virtual MenuSection MenuSection { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}
