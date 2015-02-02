using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class ExpenseType
    {
        public ExpenseType()
        {
            AssessorExpenses = new List<AssessorExpense>();
            VisitTypeExpenseTypes = new List<VisitTypeExpenseType>();
        }

        public short ExpenseTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<VisitTypeExpenseType> VisitTypeExpenseTypes { get; set; }
    }
}