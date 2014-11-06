using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class AssessorExpenseHistory
    {
        public int AssessorExpenseHistoryID { get; set; }
        public int AssessorExpenseID { get; set; }
        public int AdminID { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public short ExpenseStatusID { get; set; }
        public decimal ApprovedAmount { get; set; }
        public virtual AssessorExpense AssessorExpense { get; set; }
        public virtual ExpenseStatu ExpenseStatu { get; set; }
    }
}
