using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorExpense
    {
        public AssessorExpense()
        {
            this.AssessorExpenseHistories = new List<AssessorExpenseHistory>();
        }

        public int AssessorExpenseID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int VisitID { get; set; }
        public int AssessorID { get; set; }
        public short ExpenseTypeID { get; set; }
        public decimal ClaimedAmount { get; set; }
        public int CurrencyID { get; set; }
        public int CurrencyExchangeRateID { get; set; }
        public short CurrentExpenseStatusID { get; set; }
        public Nullable<decimal> ApprovedAmount { get; set; }
        public System.DateTime ApprovedDate { get; set; }
        public int ApproveByAdminID { get; set; }
        public virtual Assessor Assessor { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ExpenseStatu ExpenseStatu { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual Visit Visit { get; set; }
        public virtual ICollection<AssessorExpenseHistory> AssessorExpenseHistories { get; set; }
    }
}
