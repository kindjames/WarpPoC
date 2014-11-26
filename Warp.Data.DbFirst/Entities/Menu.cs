using System;
using System.Collections.Generic;

namespace Warp.Data.DbFirst.Entities
{
    public class Menu
    {
        public Menu()
        {
            MenuConfigs = new List<MenuConfig>();
        }

        public int MenuId { get; set; }
        public string Name { get; set; }
        public int AddedByAdminId { get; set; }
        public DateTime DateValidFrom { get; set; }
        public DateTime? DateValidTo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
    }
}