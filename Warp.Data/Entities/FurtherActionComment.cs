using System;

namespace Warp.Data.Entities
{
    public class FurtherActionComment
    {
        public int FurtherActionCommentId { get; set; }
        public int ActionCommentId { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public string Comment3 { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ActionComment ActionComment { get; set; }
    }
}