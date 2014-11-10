using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public partial class Menu
    {
        public Menu()
        {
            this.MenuConfigs = new List<MenuConfig>();
        }

        public int MenuID { get; set; }
        public string Name { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
    }
}
