using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Maintenance
    {
        public Maintenance()
        {
            this.MaintenanceCustomers = new List<MaintenanceCustomer>();
        }

        public int MaintenanceID { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int MaintenanceCategoryID { get; set; }
        public System.DateTime DateDisplayFrom { get; set; }
        public Nullable<System.DateTime> DateDisplayTo { get; set; }
        public string HyperlinkURL { get; set; }
        public string HyperlinkText { get; set; }
        public Nullable<int> RemovedBy { get; set; }
        public int AddedBy { get; set; }
        public bool Active { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public virtual MaintenanceCategory MaintenanceCategory { get; set; }
        public virtual ICollection<MaintenanceCustomer> MaintenanceCustomers { get; set; }
    }
}
