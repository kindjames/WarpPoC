using System;

namespace Warp.Data.Entities
{
    public class AuditingDatabase
    {
        public int DatabaseId { get; set; }
        public int UserId { get; set; }
        public int OperationId { get; set; }
        public int IdentityId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string PreviousValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Operation Operation { get; set; }
    }
}