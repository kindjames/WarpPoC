using System;

namespace Warp.Data.Entities
{
    public class VisitTypeExpenseType
    {
        public short VisitTypeExpenseTypeId { get; set; }
        public short VisitTypeId { get; set; }
        public short ExpenseTypeId { get; set; }
        public DateTime DateUpdated { get; set; }
        public DateTime DateCreated { get; set; }
        public bool Active { get; set; }
        public virtual ExpenseType ExpenseType { get; set; }
        public virtual VisitType VisitType { get; set; }
    }
}