using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class AssessorExpense
    {
        public AssessorExpense()
        {
            AssessorExpenseHistories = new List<AssessorExpenseHistory>();
        }

        public int AssessorExpenseId { get; set; }
        public int VisitId { get; set; }
        public int AssessorId { get; set; }
        public short ExpenseTypeId { get; set; }
        public decimal ClaimedAmount { get; set; }
        public int CurrencyId { get; set; }
        public int CurrencyExchangeRateId { get; set; }
        public short CurrentExpenseStatusId { get; set; }
        public decimal? ApprovedAmount { get; set; }
        public DateTime DateApproved { get; set; }
        public int ApproveByAdminId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual ExpenseStatus ExpenseStatus { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual ICollection<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
    }
}