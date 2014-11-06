using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class VisitTypeExpenseType
    {
        public short VisitTypeExpenseTypeID { get; set; }
        public short VisitTypeID { get; set; }
        public short ExpenseTypeID { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual VisitType VisitType { get; set; }
    }
}
