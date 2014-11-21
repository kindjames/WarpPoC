using System;

namespace Warp.Data.Entities
{
    public class QuestionResultAction
    {
        public int QuestionResultActionId { get; set; }
        public int QuestionResultId { get; set; }
        public int ActionId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Action Action { get; set; }
        public virtual QuestionResult QuestionResult { get; set; }
    }
}