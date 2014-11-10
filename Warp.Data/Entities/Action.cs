using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Action
    {
        public Action()
        {
            this.ActionComments = new List<ActionComment>();
            this.ActionUsers = new List<ActionUser>();
            this.QuestionResultActions = new List<QuestionResultAction>();
            this.VisitActions = new List<VisitAction>();
        }

        public int ActionID { get; set; }
        public string Title { get; set; }
        public System.DateTime Added { get; set; }
        public int AddedUser { get; set; }
        public short ActionPriorityID { get; set; }
        public short ActionTypeID { get; set; }
        public short ActionStatusID { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual User User { get; set; }
        public virtual ActionPriority ActionPriority { get; set; }
        public virtual ActionStatu ActionStatu { get; set; }
        public virtual ActionType ActionType { get; set; }
        public virtual ICollection<ActionComment> ActionComments { get; set; }
        public virtual ICollection<ActionUser> ActionUsers { get; set; }
        public virtual ICollection<QuestionResultAction> QuestionResultActions { get; set; }
        public virtual ICollection<VisitAction> VisitActions { get; set; }
    }
}
