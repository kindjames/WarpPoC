using System;

namespace Warp.Data.Entities
{
    public class AssessorExpenseHistory
    {
        public int AssessorExpenseHistoryId { get; set; }
        public int AssessorExpenseId { get; set; }
        public int AdminId { get; set; }
        public short ExpenseStatusId { get; set; }
        public decimal ApprovedAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual AssessorExpense AssessorExpense { get; set; }
        public virtual ExpenseStatus ExpenseStatus { get; set; }
    }
}