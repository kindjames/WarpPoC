using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuItemPossibleAnswer
    {
        public int MenuItemPossibleAnswerID { get; set; }
        public int MenuItemID { get; set; }
        public int PossibleAnswerID { get; set; }
        public bool Active { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual PossibleAnswer PossibleAnswer { get; set; }
    }
}
