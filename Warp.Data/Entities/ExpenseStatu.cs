using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class ExpenseStatu
    {
        public ExpenseStatu()
        {
            AssessorExpenses = new List<AssessorExpense>();
            AssessorExpenseHistories = new List<AssessorExpenseHistory>();
        }

        public short ExpenseStatusId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<AssessorExpense> AssessorExpenses { get; set; }
        public virtual ICollection<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
    }
}