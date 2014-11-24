using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class Action
    {
        public Action()
        {
            ActionComments = new List<ActionComment>();
            ActionUsers = new List<ActionUser>();
            QuestionResultActions = new List<QuestionResultAction>();
            VisitActions = new List<VisitAction>();
        }

        public int ActionId { get; set; }
        public string Title { get; set; }
        public DateTime Added { get; set; }
        public int AddedUser { get; set; }
        public short ActionPriorityId { get; set; }
        public short ActionTypeId { get; set; }
        public short ActionStatusId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual ActionPriority ActionPriority { get; set; }
        public virtual ActionStatus ActionStatus { get; set; }
        public virtual ActionType ActionType { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
        public virtual ICollection<ActionUser> ActionUsers { get; set; }
        public virtual ICollection<QuestionResultAction> QuestionResultActions { get; set; }
        public virtual ICollection<VisitAction> VisitActions { get; set; }
    }
}