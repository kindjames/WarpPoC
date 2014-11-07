using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ExpenseStatu
    {
        public ExpenseStatu()
        {
            this.AssessorExpenses = new List<AssessorExpense>();
            this.AssessorExpenseHistories = new List<AssessorExpenseHistory>();
        }

        public short ExpenseStatusID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
    }
}
