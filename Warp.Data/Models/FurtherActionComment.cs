using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class FurtherActionComment
    {
        public int FurtherActionCommentID { get; set; }
        public int ActionCommentID { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ActionComment ActionComment { get; set; }
    }
}
