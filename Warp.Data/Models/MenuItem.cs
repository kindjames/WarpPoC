using System;
using System.Collections.Generic;

namespace Warp.Data.Models
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            this.MenuConfigs = new List<MenuConfig>();
            this.MenuItemPossibleAnswers = new List<MenuItemPossibleAnswer>();
        }

        public int MenuItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool Active { get; set; }
        public virtual ICollection<MenuConfig> MenuConfigs { get; set; }
        public virtual ICollection<MenuItemPossibleAnswer> MenuItemPossibleAnswers { get; set; }
    }
}
