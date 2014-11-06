using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class Menu
    {
        public Menu()
        {
            this.MenuConfigs = new List<MenuConfig>();
        }

        public int MenuID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateAdded { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public Nullable<System.DateTime> ValidTo { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
    }
}
