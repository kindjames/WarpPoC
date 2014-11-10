using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class MaintenanceCategory
    {
        public MaintenanceCategory()
        {
            this.Maintenances = new List<Maintenance>();
        }

        public int MaintenanceCategoryID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<Maintenance> Maintenances { get; set; }
    }
}
