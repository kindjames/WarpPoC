using System;

namespace Warp.Data.Entities
{
    public class MaintenanceCustomer
    {
        public int MaintenanceCustomerId { get; set; }
        public int CustomerId { get; set; }
        public int MaintenanceId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Maintenance Maintenance { get; set; }
    }
}