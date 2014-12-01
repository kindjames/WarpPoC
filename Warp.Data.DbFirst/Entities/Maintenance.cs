using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Maintenance
    {
        public Maintenance()
        {
            MaintenanceCustomers = new List<MaintenanceCustomer>();
        }

        public int MaintenanceId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int MaintenanceCategoryId { get; set; }
        public DateTime DateDisplayFrom { get; set; }
        public DateTime? DateDisplayTo { get; set; }
        public string HyperlinkURL { get; set; }
        public string HyperlinkText { get; set; }
        public int? RemovedBy { get; set; }
        public int AddedBy { get; set; }
        public bool Active { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public virtual MaintenanceCategory MaintenanceCategory { get; set; }
        public virtual ICollection<MaintenanceCustomer> MaintenanceCustomers { get; set; }
    }
}