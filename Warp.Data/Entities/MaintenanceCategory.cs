using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class MaintenanceCategory
    {
        public MaintenanceCategory()
        {
            Maintenances = new List<Maintenance>();
        }

        public int MaintenanceCategoryId { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}