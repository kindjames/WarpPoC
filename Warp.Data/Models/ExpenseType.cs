using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class ExpenseType
    {
        public ExpenseType()
        {
            this.AssessorExpenses = new List<AssessorExpense>();
            this.VisitTypeExpenseTypes = new List<VisitTypeExpenseType>();
        }

        public short ExpenseTypeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
    }
}
