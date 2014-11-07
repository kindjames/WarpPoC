using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuConfig
    {
        public MenuConfig()
        {
            this.MenuConfigBranches = new List<MenuConfigBranch>();
            this.MenuConfigBrands = new List<MenuConfigBrand>();
            this.MenuConfigClients = new List<MenuConfigClient>();
        }

        public int MenuConfigID { get; set; }
        public int MenuID { get; set; }
        public int MenuSectionID { get; set; }
        public int MenuItemID { get; set; }
        public int AddedByAdminID { get; set; }
        public System.DateTime DateValidFrom { get; set; }
        public Nullable<System.DateTime> DateValidTo { get; set; }
        public System.DateTime DateCreated { get; set; }
        public System.DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual MenuSection MenuSection { get; set; }
        public virtual ICollection<MenuConfigBranch> MenuConfigBranches { get; set; }
        public virtual ICollection<MenuConfigBrand> MenuConfigBrands { get; set; }
        public virtual ICollection<MenuConfigClient> MenuConfigClients { get; set; }
    }
}
