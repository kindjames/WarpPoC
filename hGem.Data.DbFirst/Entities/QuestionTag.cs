using System;

namespace Warp.Data.DbFirst.Entities
{
    public class QuestionTag
    {
        public int QuestionTagId { get; set; }
        public int QuestionId { get; set; }
        public short TagId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Question Question { get; set; }
        public virtual Tag Tag { get; set; }
    }
}