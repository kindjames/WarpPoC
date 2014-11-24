using System;
using System.Collections.Generic;

namespace Warp.Data.Entities
{
    public class MenuConfig
    {
        public MenuConfig()
        {
            MenuConfigBranches = new List<MenuConfigBranch>();
            MenuConfigBrands = new List<MenuConfigBrand>();
            MenuConfigClients = new List<MenuConfigClient>();
        }

        public int MenuConfigId { get; set; }
        public int MenuId { get; set; }
        public int MenuSectionId { get; set; }
        public int MenuItemId { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual MenuSection MenuSection { get; set; }
        public virtual ICollection<MenuConfigBranch> MenuConfigBranches { get; set; }
        public virtual ICollection<MenuConfigBrand> MenuConfigBrands { get; set; }
        public virtual ICollection<MenuConfigClient> MenuConfigClients { get; set; }
    }
}